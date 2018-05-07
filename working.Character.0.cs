'From MIT Squeak 0.9.4 (June 1, 2003) [No updates present.] on 7 May 2018 at 6:49:51 pm'!

	| keyPadTarget expArg dispPosition frame |
	keyPadTarget _ World activeHand keyboardFocus.
	(keyPadTarget isKindOf: StringFieldMorph) ifTrue: [
		lastContents _ keyPadTarget contents.
		self target: keyPadTarget.
		expArg _ keyPadTarget ownerThatIsA: ExpressionArgMorph.
		frame _ expArg ownerThatIsA: ScratchFrameMorph.

		dispPosition _ expArg bottomLeft.
		((dispPosition y) + (self height)) > frame height ifTrue: [
			dispPosition _ (dispPosition x)@((dispPosition y) - (expArg height) - (self height))].
		self position: dispPosition.
		self comeToFront]
	ifFalse: [
		self delete].
! !

	^ 50! !

	| col row bt size |
	super initialize.

	self color: Color transparent.
	col _ AlignmentMorph new.
	col orientation: #vertical.
	col color: BaseColor.
	col useRoundedCorners.

	buttons _ OrderedCollection new.
	size _ (ButtonSize + (10 * ScratchTranslator renderScale)) truncated.
	#(
		#(#('-' 45) #(0 48) #('.' 46))
		#(#(7 55) #(8 56) #(9 57))
		#(#(4 52) #(5 53) #(6 54))
		#(#(1 49) #(2 50) #(3 51))
		) do: [:num1 |
		row _ AlignmentMorph new.
		row color: BaseColor.
		num1 reverseDo: [:num2 |
			bt _ (SimpleButtonMorph new)
				label: ((num2 at: 1) asString) font: (StrikeFont fontName: #Verdana size: 20);
				extent: (size@size);
				color: ButtonColor;
				borderWidth: 1;
				borderColor: FontColor;
				target: self;
				actionSelector: #input:;
				arguments: {num2 at: 2};
			(bt findA: StringMorph) color: FontColor.
			buttons add: bt.
			row addMorph: bt.
			row addMorph: (Morph new extent: (2@40); color: (Color transparent))].
		col addMorph: row].

	row _ AlignmentMorph new.
	row color: BaseColor.

	bt _ IconicButton new labelGraphic: ((ScratchFrameMorph skinAt: #bs) magnifyBy: 0.5) borderWidth: 0.
	bt target: self;
		actionSelector: #deleteChar;
	buttons add: bt.

	row addMorph: bt.
	row addMorph: (Morph new extent: (20@30); color: (Color transparent)).

	bt _ SimpleButtonMorph new
		label: 'C' font: (StrikeFont fontName: #Verdana size: 20);
		extent: (70@30);
		color: ButtonColor;
		borderWidth: 1;
		borderColor: FontColor;
		target: self;
		actionSelector: #clearTarget;
	(bt findA: StringMorph) color: FontColor.
	"buttons add: bt."
	row addMorph: bt.
	col addMorph: row.

	"col addMorph: sf."   "For debug"
	self addMorph: col.
	self extent: col extent.! !

	targetField selectAll; removeSelection.
	World activeHand newKeyboardFocus: targetField.
! !

	| curPosition |
	targetField backspace.
	curPosition _ targetField cursorPosition.
	World activeHand newKeyboardFocus: targetField.
	targetField moveCursorAt: curPosition.
! !

	| curPosition |
	targetField contents: lastContents.
	((aValue = 46) not & lastContents = '0') ifTrue: [
		targetField selectAll].

	targetField insertCharacter: aValue.
	curPosition _ targetField cursorPosition.
	World activeHand newKeyboardFocus: targetField.
	targetField moveCursorAt: curPosition.
! !

	targetField _ aStringField.

"	buttons do: [:bt |
		bt target: aStringField]
"! !
	"self initialize"

	BaseColor _ Color r: 0.753 g: 0.764 b: 0.776.
	ButtonColor _ Color r: 0.3 g: 0.3 b: 0.3.
	FontColor _ Color white.
	ButtonSize _ 40.
! !