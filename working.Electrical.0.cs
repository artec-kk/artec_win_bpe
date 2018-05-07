'From MIT Squeak 0.9.4 (June 1, 2003) [No updates present.] on 22 March 2018 at 6:10:51 pm'!
	| t2 |

	" Check if a single character or a string."
	(t1 size = 2) ifTrue: [
		t2 _ t1 at: 2.	]
	ifFalse: [
		t2 _ t1 copyFrom: 2 to: (t1 size).].

	$a = t2 ifTrue: [^ AttributeArgMorph new choice: 'volume'].
	$b = t2 ifTrue: [^ BooleanArgMorph new].
	$B = t2 ifTrue: [^ ChoiceArgMorph new getOptionsSelector: #bzrPinNo;
		 choice: 'A0'].
	$c = t2 ifTrue: [^ ColorArgMorph new showPalette: true].
	$C = t2 ifTrue: [^ ColorArgMorph new showPalette: false].
	$d = t2 ifTrue: [^ ExpressionArgMorphWithMenu new numExpression: '0';
		 menuSelector: #directionMenu].
	$D = t2 ifTrue: [^ ExpressionArgMorphWithMenu new numExpression: '48';
		 menuSelector: #midiDrumMenu].
	$e = t2 ifTrue: [^ EventTitleMorph new].
	$E = t2 ifTrue: [^ NumericUpDownMorph new  setDefault:10 min:0 max:20 width:15 isEdit:true].
	$f = t2 ifTrue: [^ ChoiceArgMorph new getOptionsSelector: #mathFunctionNames;
		 choice: 'sqrt'].
	$F = t2 ifTrue: [^ NumericUpDownMorph new  setDefault:90 min:0 max:180 width:20 isEdit:true].
	$g = t2 ifTrue: [^ ChoiceArgMorph new getOptionsSelector: #graphicEffectNames;
		 choice: 'color'].
	$H = t2 ifTrue: [^ ChoiceArgMorph new getOptionsSelector: #hookupSensorNames].
	$h = t2 ifTrue: [^ ChoiceArgMorph new getOptionsSelector: #hookupBooleanSensorNames].
	$I = t2 ifTrue: [^ ExpressionArgMorphWithMenu new numExpression: '1';
		 menuSelector: #midiInstrumentMenu].
"	$i = t2 ifTrue: [^ ExpressionArgMorphWithMenu new numExpression: '1';
		 menuSelector: #listIndexMenu]."
	$i = t2 ifTrue: [^ ExpressionArgMorph new numExpression: '10'].
	$j = t2 ifTrue: [^ ChoiceArgMorph new getOptionsSelector: #dcMotorNo;
		 choice: 'PIN'].
	$J = t2 ifTrue: [^ ChoiceArgMorph new getOptionsSelector: #svMotorNo;
		 choice: 'PIN'].
	$k = t2 ifTrue: [^ ChoiceArgMorph new getOptionsSelector: #keyNames;
		 choice: 'space'].
	$L = t2 ifTrue: [^ ChoiceArgMorph new getOptionsSelector: #listVarMenu].
	$l = t2 ifTrue: [^ ChoiceOrExpressionArgMorph new getOptionsSelector: #costumeNames;
		 choice: 'costume1'].
	$m = t2 ifTrue: [^ SpriteArgMorph new].
	$M = t2 ifTrue: [^ ChoiceArgMorph new getOptionsSelector: #motorNames].
	$n = t2 ifTrue: [^ ExpressionArgMorph new numExpression: '10'].
	$N = t2 ifTrue: [^ ExpressionArgMorphWithMenu new numExpression: '60';
		 menuSelector: #noteSelector].
	$o = t2 ifTrue: [^ ChoiceArgMorph new getOptionsSelector: #ledOnOff;
		 choice: 'on'].
	$O = t2 ifTrue: [^ ChoiceArgMorph new getOptionsSelector: #hookupSoundPin].
	$p = t2 ifTrue: [^ ChoiceArgMorph new getOptionsSelector: #ledPinNo;
		 choice: 'A0'].
	'p1' = t2 ifTrue: [^ ChoiceArgMorph new getOptionsSelector: #boardLED;
			choice: 'Red(D5)'.].
	$P = t2 ifTrue: [^ ChoiceArgMorph new getOptionsSelector: #hookupLightPin].
	$q = t2 ifTrue: [^ ChoiceArgMorph new getOptionsSelector: #moveDirection;
		 choice: 'Forward'].
	$s = t2 ifTrue: [^ ExpressionArgMorph new stringExpression: ''].
	$S = t2 ifTrue: [^ ChoiceOrExpressionArgMorph new getOptionsSelector: #soundNames;
		 choice: 'pop'].
	$t = t2 ifTrue: [^ ChoiceArgMorph new getOptionsSelector: #dcMotorOn;
		 choice: 'cw.'].
	$T = t2 ifTrue: [^ ChoiceArgMorph new getOptionsSelector: #dcMotorOff;
		 choice: 'Brake'].
	$U = t2 ifTrue: [^ ChoiceArgMorph new getOptionsSelector: #hookupSensorsPin].
	$v = t2 ifTrue: [^ ChoiceArgMorph new getOptionsSelector: #varNamesMenu;
		 choice: ''].
	$V = t2 ifTrue: [^ ChoiceArgMorph new getOptionsSelector: #hookupTouchPin].
	$w = t2 ifTrue: [^ ChoiceArgMorph new getOptionsSelector: #temperaturePinNo].
	$W = t2 ifTrue: [^ ChoiceArgMorph new getOptionsSelector: #motorDirection].
	$x = t2 ifTrue: [^ ChoiceOrExpressionArgMorph new getOptionsSelector: #sceneNames;
		 choice: ''].
	$X = t2 ifTrue: [^ ChoiceArgMorph new getOptionsSelector: #hookupARButton].
"	$y = t2 ifTrue: [^ ExpressionArgMorphWithMenu new numExpression: '1';
		 menuSelector: #listIndexForDeleteMenu]."
	$y = t2 ifTrue: [^ ExpressionArgMorph new numExpression: '10'].
	$Y = t2 ifTrue: [^ ChoiceArgMorph new getOptionsSelector: #hookupARSensorXYZ].
	$z = t2 ifTrue: [^ ChoiceArgMorph new getOptionsSelector: #hookupARSensorNames].
	$Z = t2 ifTrue: [^ ChoiceArgMorph new getOptionsSelector: #hookupIRPin].
	'Z1' = t2 ifTrue: [^ ChoiceArgMorph new getOptionsSelector: #clockVars].
^ ExpressionArgMorph new numExpression: '10'! !

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
	"Read I/O Port Information from .bpde file"

	| i id newBoardType |
	(self hasStandardIO: fileStream) ifTrue: [
		newBoardType _ 0.
		IOPort _ Array new: 18]
	ifFalse: [
		BoardType = 0 ifTrue: [
			self error: 'unsupported0'.
			^ nil].
		newBoardType _ 1.
		IOPort _ Array new: 19].

	newBoardType = BoardType ifFalse: [
		BoardType _ newBoardType.
		self sendBoardTypeToBM].

	i _ 1.
	IOPort size timesRepeat: [
		id _ fileStream next.
		flag ifTrue: [
			(id > 21 and: [(id = 16r18) not]) ifTrue: [
				id _ 0.
				versionConflict _ true.
			].
			IOPort at: i put: id.
		]
		ifFalse: [
			(id > 21 and: [(id = 16r18) not]) ifTrue: [
				versionConflict _ true.
			].
		].
		i _ i + 1.
	].
	^ fileStream.
! !

	| newBoardType ioSize id |

	(self hasStandardIO: stream) ifTrue: [
		newBoardType _ 0.
		ioSize _ 18]
	ifFalse: [
		newBoardType _ 1.
		ioSize _ 19].

	ioSize timesRepeat: [
		id _ stream next.
		(id > 21 and: [(id = 16r18) not]) ifTrue: [
			versionConflict _ true]].

	^ newBoardType! !
	" Check I/O pin configuration and reflect for argument "
	"Answer a collection of button number."

	| offset id validPin |

	offset _ 10.
	validPin _ OrderedCollection new.
	1 to: 8 do: [ :index |
		id _ IOPort at: (index + offset).
		id = 16r18 ifTrue: [
			validPin add: 'A', (index-1) asString.
		]
	].	

	^ validPin.
! !
	"Answer the value of the given sensor, or zero if the sensorboard is not available."

	^ self sensor: sensorName.
! !
	"Answer the default argument for the given block specification."

	| defaultArgs stage sel currentSize list offset isDetect partsID arrPort |
	defaultArgs _ blockSpec copyFrom: 4 to: blockSpec size.  "may be empty"
	stage _ self ownerThatIsA: ScratchStageMorph.

	sel _ (blockSpec at: 3) asSymbol.
	#gotoX:y: = sel ifTrue: [
		defaultArgs _ Array
			with: self referencePosition x rounded
			with: self referencePosition y rounded].

	#glideSecs:toX:y:elapsed:from: = sel ifTrue: [
		defaultArgs _ Array
			with: 1
			with: self referencePosition x rounded
			with: self referencePosition y rounded].

	#motor:direction: = self ifTrue: [
		defaultArgs _ Array with: 'reverse' localized with: 'this way' localized with: 'that way'].

	#setSizeTo: = sel ifTrue: [
		currentSize _ (100.0 * (self scalePoint x max: self scalePoint y)) rounded.
		defaultArgs _ Array with: currentSize].

	#getAttribute:of: = sel ifTrue: [
		(stage _ self ownerThatIsA: ScratchStageMorph) ifNotNil: [
			list _ stage submorphs select: [:m | m isKindOf: ScratchSpriteMorph].
			list sort: [:s1 :s2 | s1 objName asLowercase < s2 objName asLowercase].
			list size > 0
				ifTrue: [defaultArgs _ Array with: 'x position' with: list first]
				ifFalse: [defaultArgs _ Array with: 'background #' with: stage]]
		ifNil:[defaultArgs _ Array with: 'x position' with: self]].

	#concatenate:with: = sel ifTrue: [
		defaultArgs _ Array with: 'hello ' localized with: 'world' localized].

	#doAsk = sel ifTrue: [
		defaultArgs _ Array with: 'What''s your name?' localized].

	#letter:of: = sel ifTrue: [
		defaultArgs _ Array with: 1 with: 'world' localized].

	#stringLength: = sel ifTrue: [
		defaultArgs _ Array with: 'world' localized].

	#say:duration:elapsed:from: = sel ifTrue: [
		defaultArgs _ Array with: 'Hello!!' localized with: 2].

	#say: = sel ifTrue: [
		defaultArgs _ Array with: 'Hello!!' localized].

	#think:duration:elapsed:from: = sel ifTrue: [
		defaultArgs _ Array with: 'Hmm...' localized with: 2].

	#think: = sel ifTrue: [
		defaultArgs _ Array with: 'Hmm...' localized].

	(#(lookLike: showBackground:) includes: sel) ifTrue: [
		defaultArgs _ Array with: self costumeNames last].

	(#(playSound: doPlaySoundAndWait) includes: sel) ifTrue: [
		list _ self soundNames.
		defaultArgs _ list size <= 2
			ifTrue: [Array with: '']
			ifFalse: [Array with: (list at: (list size - 2))]].

	(#(broadcast: doBroadcastAndWait) includes: sel) ifTrue: [
		stage ifNotNil: [defaultArgs _ Array with: stage defaultEventName]].

	(#(append:toList: deleteLine:ofList: insert:at:ofList:) includes: sel) ifTrue: [
		defaultArgs size >= 1 ifTrue: [
			defaultArgs at: 1 put: (defaultArgs at: 1) localized]].

	(#(append:toList: deleteLine:ofList: getLine:ofList: insert:at:ofList: lineCountOfList:)
		includes: sel) ifTrue: [
			defaultArgs _ defaultArgs copyWith: self defaultListName].

	#setLine:ofList:to: = sel ifTrue: [
		defaultArgs size >= 3 ifTrue: [
			defaultArgs at: 2 put: self defaultListName.
			defaultArgs at: 3 put: (defaultArgs at: 3) localized]].

	#appendLettersOf:toList: = sel ifTrue: [
		defaultArgs size >= 2 ifTrue: [
			defaultArgs at: 1 put: (defaultArgs at: 1) localized.
			defaultArgs at: 2 put: self defaultListName]].

	#list:contains: = sel ifTrue: [
		defaultArgs size >= 2 ifTrue: [
			defaultArgs at: 1 put: self defaultListName.
			defaultArgs at: 2 put: (defaultArgs at: 2) localized]].

	((#motorNo:power: = sel) | (#motorNo:dcMotorOn: = sel) | (#motorNo:dcMotorOff: = sel)) ifTrue: [
		isDetect _ false.			" detect DC motor? "
		offset _ 0.				" 1-2:DC 3-10:SV 11-18:Sensor "
		partsID _ 16r01.			" 01:DC 02:SV 03:LED 04:BZR 05:CLED 10:LS 11:TS 12:SS 13:IRS 14:3S 15:BTN"
		defaultArgs at: 1 put: ''.
		1 to: 2 do: [ :index |
			(((IOPort at: (index+offset)) = partsID) & (isDetect = false)) ifTrue: [
				(index = 1) ifTrue: [ defaultArgs at: 1 put: 'M1'. isDetect _ true. ].
				(index = 2) ifTrue: [ defaultArgs at: 1 put: 'M2'. isDetect _ true. ].
			]
		].
	].

	#motorNo:degree: = sel ifTrue: [
		isDetect _ false.			" detect servo motor? "
		offset _ 2.				" 1-2:DC 3-10:SV 11-18:Sensor "
		partsID _ 16r02.			" 01:DC 02:SV 03:LED 04:BZR 05:CLED 10:LS 11:TS 12:SS 13:IRS 14:3S 15:BTN"
		defaultArgs at: 1 put: ''.	""
		(BoardType = 0 or: [BoardType = 2]) ifTrue: [
			arrPort _ #('D2' 'D4' 'D7' 'D8' 'D9' 'D10' 'D11' 'D12').]
		ifFalse: [ " Studuino mini "
			arrPort _ #('D5' 'D6' 'D9' 'D10' 'D11').].

		1 to: (arrPort size) do: [:index |
			((IOPort at: (index + offset)) = partsID) ifTrue: [
				defaultArgs at: 1 put: (arrPort at: index).
				^ defaultArgs.].].
"
		1 to: 8 do: [ :index |
			(((IOPort at: (index+offset)) = partsID) & (isDetect = false)) ifTrue: [
				(index = 1) ifTrue: [ defaultArgs at: 1 put: 'D2'. isDetect _ true. ].
				(index = 2) ifTrue: [ defaultArgs at: 1 put: 'D4'. isDetect _ true. ].
				(index = 3) ifTrue: [ defaultArgs at: 1 put: 'D7'. isDetect _ true. ].
				(index = 4) ifTrue: [ defaultArgs at: 1 put: 'D8'. isDetect _ true. ].
				(index = 5) ifTrue: [ defaultArgs at: 1 put: 'D9'. isDetect _ true. ].
				(index = 6) ifTrue: [ defaultArgs at: 1 put: 'D10'. isDetect _ true. ].
				(index = 7) ifTrue: [ defaultArgs at: 1 put: 'D11'. isDetect _ true. ].
				(index = 8) ifTrue: [ defaultArgs at: 1 put: 'D12'. isDetect _ true. ].
			]
		].
"
	].

	(#ledPin:onOff: = sel) ifTrue: [
		isDetect _ false.			" detect buzzer? "
		offset _ 10.				" 1-2:DC 3-10:SV 11-18:Sensor "
		partsID _ 16r03.			" 01:DC 02:SV 03:LED 04:BZR 05:CLED 10:LS 11:TS 12:SS 13:IRS 14:3S 15:BTN"
		defaultArgs at: 1 put: ''.
		1 to: 6 do: [ :index |
			(((IOPort at: (index+offset)) = partsID) & (isDetect = false)) ifTrue: [
				defaultArgs at: 1 put: ('A', (index-1) asString).
				isDetect _ true.
			]
		].
	].

	((#buzzerPin:freq: = sel) | (#buzzerPin: = sel)) ifTrue: [
		isDetect _ false.			" detect buzzer? "
		offset _ 10.				" 1-2:DC 3-10:SV 11-18:Sensor "
		partsID _ 16r04.			" 01:DC 02:SV 03:LED 04:BZR 05:CLED 10:LS 11:TS 12:SS 13:IRS 14:3S 15:BTN"
		defaultArgs at: 1 put: ''.
		1 to: 6 do: [ :index |
			(((IOPort at: (index+offset)) = partsID) & (isDetect = false)) ifTrue: [
				defaultArgs at: 1 put: ('A', (index-1) asString).
				isDetect _ true.
			]
		].
	].

	(#lightSensor: = sel) ifTrue: [
		isDetect _ false.			" detect buzzer? "
		offset _ 10.				" 1-2:DC 3-10:SV 11-18:Sensor "
		partsID _ 16r10.			" 01:DC 02:SV 03:LED 04:BZR 05:CLED 10:LS 11:TS 12:SS 13:IRS 14:3S 15:BTN"
		defaultArgs at: 1 put: ''.
		(BoardType = 0 or: [BoardType = 2]) ifTrue: [
			arrPort _ #('A0' 'A1' 'A2' 'A3' 'A4' 'A5' 'A6' 'A7').]
		ifFalse: [ " Studuino mini "
			arrPort _ #('A0' 'A1' 'A2' 'A3' 'A4' 'A5').].

		1 to: (arrPort size) do: [:index |
			((IOPort at: (index + offset)) = partsID) ifTrue: [
				defaultArgs at: 1 put: (arrPort at: index).
				^ defaultArgs.].].
"
		1 to: 8 do: [ :index |
			(((IOPort at: (index+offset)) = partsID) & (isDetect = false)) ifTrue: [
				defaultArgs at: 1 put: ('A', (index-1) asString).
				isDetect _ true.
			]
		].
"
	].

	(#touchSensor: = sel) ifTrue: [
		isDetect _ false.			" detect buzzer? "
		offset _ 10.				" 1-2:DC 3-10:SV 11-18:Sensor "
		partsID _ 16r11.			" 01:DC 02:SV 03:LED 04:BZR 05:CLED 10:LS 11:TS 12:SS 13:IRS 14:3S 15:BTN"
		defaultArgs at: 1 put: ''.
		1 to: 6 do: [ :index |
			(((IOPort at: (index+offset)) = partsID) & (isDetect = false)) ifTrue: [
				defaultArgs at: 1 put: ('A', (index-1) asString).
				isDetect _ true.
			]
		].
	].

	(#soundSensor: = sel) ifTrue: [
		isDetect _ false.			" detect buzzer? "
		offset _ 10.				" 1-2:DC 3-10:SV 11-18:Sensor "
		partsID _ 16r12.			" 01:DC 02:SV 03:LED 04:BZR 05:CLED 10:LS 11:TS 12:SS 13:IRS 14:3S 15:BTN"
		defaultArgs at: 1 put: ''.
		1 to: 8 do: [ :index |
			(((IOPort at: (index+offset)) = partsID) & (isDetect = false)) ifTrue: [
				defaultArgs at: 1 put: ('A', (index-1) asString).
				isDetect _ true.
			]
		].
	].

	(#refPhotosensor: = sel) ifTrue: [
		isDetect _ false.			" detect buzzer? "
		offset _ 10.				" 1-2:DC 3-10:SV 11-18:Sensor "
		partsID _ 16r13.			" 01:DC 02:SV 03:LED 04:BZR 05:CLED 10:LS 11:TS 12:SS 13:IRS 14:3S 15:BTN"
		defaultArgs at: 1 put: ''.
		1 to: 8 do: [ :index |
			(((IOPort at: (index+offset)) = partsID) & (isDetect = false)) ifTrue: [
				defaultArgs at: 1 put: ('A', (index-1) asString).
				isDetect _ true.
			]
		].
	].

	(#accelerometer: = sel) ifTrue: [
		isDetect _ false.			" detect buzzer? "
		offset _ 10.				" 1-2:DC 3-10:SV 11-18:Sensor "
		partsID _ 16r14.			" 01:DC 02:SV 03:LED 04:BZR 05:CLED 10:LS 11:TS 12:SS 13:IRS 14:3S 15:BTN"
		defaultArgs at: 1 put: ''.
		1 to: 8 do: [ :index |
			(((IOPort at: (index+offset)) = partsID) & (isDetect = false)) ifTrue: [
				defaultArgs at: 1 put: 'X'.
				isDetect _ true.
			]
		].
	].

	(#onBoardButton: = sel) ifTrue: [
		isDetect _ false.			" detect buzzer? "
		offset _ 10.				" 1-2:DC 3-10:SV 11-18:Sensor "
		partsID _ 16r15.			" 01:DC 02:SV 03:LED 04:BZR 05:CLED 10:LS 11:TS 12:SS 13:IRS 14:3S 15:BTN"
		defaultArgs at: 1 put: ''.
		1 to: 4 do: [ :index |
			(((IOPort at: (index+offset)) = partsID) & (isDetect = false)) ifTrue: [
				defaultArgs at: 1 put: ('A', (index-1) asString).
				isDetect _ true.
			]
		].
	].

	(#temperatureSensor: = sel) ifTrue: [
		isDetect _ false.			" detect buzzer? "
		offset _ 10.				" 1-2:DC 3-10:SV 11-18:Sensor "
		partsID _ 16r18.
		defaultArgs at: 1 put: ''.
		1 to: 8 do: [ :index |
			(((IOPort at: (index+offset)) = partsID) & (isDetect = false)) ifTrue: [
				defaultArgs at: 1 put: ('A', (index-1) asString).
				isDetect _ true.
			]
		].
	].

	(#boardLED:onOff: = sel) ifTrue: [
		isDetect _ false.			" detect buzzer? "
		partsID _ 16r05.			" 01:DC 02:SV 03:LED 04:BZR 05:CLED 10:LS 11:TS 12:SS 13:IRS 14:3S 15:BTN"
Transcript show: (IOPort at: 3); cr.
		defaultArgs at: 1 put: ''.
		((IOPort at: 3) = partsID) & (isDetect not) ifTrue: [
			defaultArgs at: 1 put: 'Red(D5)'.
			isDetect _ true].
		((IOPort at: 4) = partsID) & (isDetect not) ifTrue: [
			defaultArgs at: 1 put: 'Yellow(D6)'.
			isDetect _ true].
		((IOPort at: 5) = partsID) & (isDetect not) ifTrue: [
			defaultArgs at: 1 put: 'Green(D9)'.
			isDetect _ true].
	].

	^ defaultArgs
! !

	| stacks hats evtName index partsName portName offset f j b initCode |

	stacks _ blocksBin submorphs select: [:m | m isKindOf: BlockMorph].
	stacks size = 0 ifTrue: [
		^ self].

	hats _ stacks select: [:m | m isKindOf: HatBlockMorph].

	" Include file declaration "

	aStream nextPutAll: '// ---------------------------------------'; cr.
	aStream nextPutAll: '// Servomotor calibration data'; cr.
	aStream nextPutAll: '// ---------------------------------------'; cr.
	aStream nextPutAll: 'char SvCalibrationData[] = { '.

	(BoardType = 0 or: [BoardType = 2]) ifTrue: [
		5 to: 8 do: [:i|
			offset _ SvCalib at:(i).
			aStream nextPutAll: offset asString, ', '].
		1 to: 4 do: [:i|
			offset _ SvCalib at:(i).
			aStream nextPutAll: offset asString, ', ']]
	ifFalse: [ " Studuino mini "
		SvCalib do: [:elm |
			offset _ elm.
			aStream nextPutAll: offset asString, ', '.]	].

	aStream nextPutAll: ' };'; cr.
	aStream nextPutAll: '// ---------------------------------------'; cr.
	aStream nextPutAll: '// DC motor calibration data'; cr.
	aStream nextPutAll: '// ---------------------------------------'; cr.
	aStream nextPutAll: 'byte DCCalibrationData[] = { '.
	offset _ DCCalib at:(1).
	aStream nextPutAll: offset asString, ', '.
	offset _ DCCalib at:(2).
	aStream nextPutAll: offset asString.
	aStream nextPutAll: ' };'; cr.

	" Prototype declaration "
	aStream nextPutAll: '// ---------------------------------------'; cr.
	aStream nextPutAll: '// prototype declaration'; cr.
	aStream nextPutAll: '// ---------------------------------------'; cr.
	hats do: [:item |
		evtName _ item eventName.
		evtName = 'Scratch-StartClicked'
			ifTrue: [aStream nextPutAll: 'void artecRobotMain();']
			ifFalse: [aStream nextPutAll: 'void ARSR_', evtName, '();'].
		aStream cr.
	].


	aStream nextPutAll: '// ---------------------------------------'; cr.
	aStream nextPutAll: '// Global variable'; cr.
	aStream nextPutAll: '// ---------------------------------------'; cr.
	"Define value"
	self varNames do: [:v |
		aStream nextPutAll: 'float ARVAL_' , v, ';'.
		aStream cr.
	].
	"Define list"
	self listVarNames do: [:v |
		aStream nextPutAll: 'cell ARLIST_' , v, ';'.
		aStream cr.
	].
	aStream nextPutAll: 'byte port[8];';cr.
	aStream nextPutAll: 'byte degree[8];';cr.

	aStream nextPutAll: '// ---------------------------------------'; cr.
	aStream nextPutAll: '// Artec robot setup routine'; cr.
	aStream nextPutAll: '// ---------------------------------------'; cr.
	aStream nextPutAll: 'void artecRobotSetup() {'; cr.

	"For Studuino mini clock initialization."
	(BoardType == 1) ifTrue: [
		((IOPort at: 19) = 6) ifTrue: [ "Clock is enabled."
			aStream nextPutAll: '    board.InitClock();'; cr.].].

	index _ 0.
	IOPort do: [ :partsID |
		(partsID ~= 0) ifTrue: [
			(index = 0) ifTrue: [
				aStream nextPutAll: '    board.InitDCMotorPort(PORT_M1);'; cr.
"Transcript show: 'initDCMotor('; show:index; show: ');'; cr."
			].
			(index = 1) ifTrue: [
				aStream nextPutAll: '    board.InitDCMotorPort(PORT_M2);'; cr.
"Transcript show: 'initDCMotor('; show:index; show: ');'; cr."
			].

	" Board selection "
	(BoardType = 0 or: [BoardType = 2]) ifTrue: [	" For Studuino "
			(index = 2) ifTrue: [
				aStream nextPutAll: '    board.InitServomotorPort(PORT_D2);'; cr.
			].
			(index = 3) ifTrue: [
				aStream nextPutAll: '    board.InitServomotorPort(PORT_D4);'; cr.
			].
			(index = 4) ifTrue: [
				aStream nextPutAll: '    board.InitServomotorPort(PORT_D7);'; cr.
			].
			(index = 5) ifTrue: [
				aStream nextPutAll: '    board.InitServomotorPort(PORT_D8);'; cr.
			].
			(index = 6) ifTrue: [
				aStream nextPutAll: '    board.InitServomotorPort(PORT_D9);'; cr.
			].
			(index = 7) ifTrue: [
				aStream nextPutAll: '    board.InitServomotorPort(PORT_D10);'; cr.
			].
			(index = 8) ifTrue: [
				aStream nextPutAll: '    board.InitServomotorPort(PORT_D11);'; cr.
			].
			(index = 9) ifTrue: [
				aStream nextPutAll: '    board.InitServomotorPort(PORT_D12);'; cr.
			].]
	ifFalse: [	" For Studuino mini "
		((index > 1) & (index < 10)) ifTrue: [
			(partsID = 2) ifTrue: [
				initCode _ '    board.InitServomotorPort(']
			ifFalse: [
				initCode _ '    board.InitDigitalPort('].

			(index = 2) ifTrue: [
				initCode _ initCode, 'PORT_D5'.].
			(index = 3) ifTrue: [
				initCode _ initCode, 'PORT_D6'.].
			(index = 4) ifTrue: [
				initCode _ initCode, 'PORT_D9'.].
			(index = 5) ifTrue: [
				initCode _ initCode, 'PORT_D10'.].
			(index = 6) ifTrue: [
				initCode _ initCode, 'PORT_D11'.].
			(partsID = 5) ifTrue: [
				initCode _ initCode, ', PIDLED'.].
			aStream nextPutAll: initCode, ');'; cr.].].

"
			((index > 1) & (index < 10)) ifTrue: [
				aStream nextPutAll: '    initSVMotor('.
				aStream nextPutAll: (index-2) asString.
				aStream nextPutAll: ');'; cr.
			].
"
			(index > 9) & (index < 18) ifTrue: [
				(partsID = 16r03) ifTrue: [ partsName _ 'PIDLED' ].
				(partsID = 16r04) ifTrue: [ partsName _ 'PIDBUZZER' ].
				(partsID = 16r05) ifTrue: [ partsName _ 'PIDCOLORLED' ].
				(partsID = 16r10) ifTrue: [ partsName _ 'PIDLIGHTSENSOR' ].
				(partsID = 16r11) ifTrue: [ partsName _ 'PIDTOUCHSENSOR' ].
				(partsID = 16r12) ifTrue: [ partsName _ 'PIDSOUNDSENSOR' ].
				(partsID = 16r13) ifTrue: [ partsName _ 'PIDIRPHOTOREFLECTOR' ].
				(partsID = 16r14) ifTrue: [ partsName _ 'PIDACCELEROMETER' ].
				(partsID = 16r15) ifTrue: [ partsName _ 'PIDPUSHSWITCH' ].
				(partsID = 16r18) ifTrue: [ partsName _ 'PIDTEMPERATURESENSOR' ].

				(index = 10) ifTrue: [ portName _ 'PORT_A0' ].
				(index = 11) ifTrue: [ portName _ 'PORT_A1' ].
				(index = 12) ifTrue: [ portName _ 'PORT_A2' ].
				(index = 13) ifTrue: [ portName _ 'PORT_A3' ].
				(index = 14) ifTrue: [ portName _ 'PORT_A4' ].
				(index = 15) ifTrue: [ portName _ 'PORT_A5' ].
				(index = 16) ifTrue: [ portName _ 'PORT_A6' ].
				(index = 17) ifTrue: [ portName _ 'PORT_A7' ].

				aStream nextPutAll: '    board.InitSensorPort('.
				aStream nextPutAll: portName.
				aStream nextPutAll: ', '.
				aStream nextPutAll: partsName.
				aStream nextPutAll: ');'; cr.

"Transcript show: 'initSensorPin('; show:(index-10); show: ', '; show:partsName; show: ');'; cr."
			].
		].
		index _ index + 1.
	].

	aStream nextPutAll: '    board.SetServomotorCalibration(SvCalibrationData);'; cr.
	aStream nextPutAll: '    board.SetDCMotorCalibration(DCCalibrationData);'; cr.
	aStream nextPutAll: '}'; cr.

	NumberOfdoRepeat _ 0.
	hats do: [:item |
		item printArduCodeOn: aStream indent: 0.
		(item isKindOf: ReporterBlockMorph) ifTrue: [aStream cr].
		aStream cr].

! !

	| blocks |
	blocks _ #(
		'sensing'
"
			('ask %s and wait'			s	doAsk 'What''s your name?')
			('answer'					r	answer)
			-
			('mouse x'					r	mouseX)
			('mouse y'					r	mouseY)
			('mouse down?'				b	mousePressed)
			-
			('key %k pressed?'			b	keyPressed: 'space')
			-
			('reset timer'				-	timerReset)
			('timer'						r	timer)
			-
			('%a of %m'					r	getAttribute:of:)
			-
			('loudness'					r	soundLevel)
			('loud?'						b	isLoud)
			~
			('%H sensor value'			r	sensor: 'slider')
			('sensor %h?'				b	sensorPressed: 'button pressed')
			~
"
"
			('set servo motor %J to %n degrees'			-	motorNo:degree: 'No.1' 90)
			('set DC motor %j  %z'		-	motorNo:onOff: 'No.1' 'on')
			('Light Sensor %P value'		r	lightSensor: 'PIN')
			('Sound Sensor %O value'	r	soundSensor: 'PIN')
			('IR Photoreflector %Z value'	r	refPhotosensor: 'PIN')
			('Temperature sensor %w value'	r	temperatureSensor: 'PIN')
			('3-Axis Digital Accelerometer %Y value'	r	accelerometer: 'AXIS')
			('Button %X value'	r		onBoardButton: 'PIN')
"
			('Sensor %U value'		r	sensors: 'PIN')
"			~
			('reset timer'				-	timerReset)
			('timer'						r	timer)
			~
"
		'sensing mini'
			('Clock''s %Z1'	r	clockValue: 'Hour')
			('becoming in alarm time'		b	isInAlarm)
			('Onboard Light Sensor value'	r		onBoardLightSensor)
			('Power value'	r		power)
		'looks'
"xxx
			('switch to background %l'	-	showBackground: 'background1')
			('next background'			-	nextBackground)
			('background #'				r	backgroundIndex)
			-
			('change %g effect by %n'	-	changeGraphicEffect:by: 'color' 25)
			('set %g effect to %n'		-	setGraphicEffect:to: 'color' 0)
			('clear graphic effects'		-	filterReset)
			-
"
"xxx			('place sprites for scene %x'	-	showScene:) "
		'pen'
"xxx
			('clear'						-	clearPenTrails)
"
	).

	^ blocks, super blockSpecs
! !

	| readoutNames sensorID offset light touch sound infrared acceleration button setAcceleration open led buzzer colorLED kindOfSensor sizeAx tmp header cont temperature |

	" Check IOPort "
"	Transcript show:'[SensorBoardMorph::addReadouts] ';show:(IOPort);cr."

	offset _ 10.		" Offset for sensor ID "
	open _ 16r00.			" Not connected "
	led _ 16r03.				" LED ID "
	buzzer _ 16r04.			" Buzzer ID "
	colorLED _ 16r05.		" Color LED ID "
	light _ 16r10.			" Light sensor ID "
	touch _ 16r11.			" Touch sensor ID "
	sound _ 16r12.			" Sound sensor ID "
	infrared _ 16r13.		" IR Photoreflector ID "
	acceleration _ 16r14.		" Accelerometer ID "
	button _ 16r15.			" Button sensor ID "
	temperature _ 16r18.		" Temperature sensor ID "
	setAcceleration _ false.	" Set acceleration sensor flag "

	(BoardType = 0 or: [BoardType = 2]) ifTrue: [
		sizeAx _ 8.]
	ifFalse: [
		sizeAx _ 6.].
	readoutNames _ OrderedCollection new.
	1 to: sizeAx do: [ :index |
		sensorID _ IOPort at: (index + offset).
		(sensorID = open) ifTrue: [	" Not connected "
			readoutNames add:'[A', (index - 1) asString,']',' Not connected'.
		].
		(sensorID = led) ifTrue: [	" LED "
			readoutNames add:'[A', (index - 1) asString,']',' LED'.
		].
		(sensorID = buzzer) ifTrue: [	" Buzzer "
			readoutNames add:'[A', (index - 1) asString,']',' Buzzer'.
		].
		(sensorID = colorLED) ifTrue: [	" Color LED "
			readoutNames add:'[A', (index - 1) asString,']',' Color LED'.
		].
		(sensorID = light) ifTrue: [	" Light Sensor "
			readoutNames add:'[A', (index - 1) asString,']',' Sensor'.
		].
		(sensorID = touch) ifTrue: [	" Touch Sensor "
			readoutNames add:'[A', (index - 1) asString,']',' Touch sensor'.
		].
		(sensorID = sound) ifTrue: [	" Sound Sensor "
			readoutNames add:'[A', (index - 1) asString,']',' Sound sensor'.
		].
		(sensorID = infrared) ifTrue: [	" IR Photoreflector "
			readoutNames add:'[A', (index - 1) asString,']',' Sensor'.
		].
		(sensorID = acceleration) ifTrue: [	" Accelerometer "
			(setAcceleration = false) ifTrue: [
				readoutNames add:'[A4/A5] Accelerometer (X)'.
				readoutNames add:'[A4/A5] Accelerometer (Y)'.
				readoutNames add:'[A4/A5] Accelerometer (Z)'.
				setAcceleration _ True.
			].
		].
		(sensorID = temperature) ifTrue: [	" Temperature sensor "
			readoutNames add:'[A', (index - 1) asString,']',' Sensor'.
			listTempBuf at: index put: (TemperatureSensor new).
		].
		(sensorID = button) ifTrue: [	" Button "
			readoutNames add:'[A', (index - 1) asString,']',' Button'.
		].
	].
	column _ AlignmentMorph newColumn
		centering: #center;
		hResizing: #spaceFill;
		vResizing: #shrinkWrap;
		color: (Color r: (193/255) g: (196/255) b: (199/255));
		borderWidth: 2;
		borderColor: (Color r: (148/255) g: (145/255) b: (145/255));
		useRoundedCorners;
		inset: 3.

	titleMorph _ StringMorph
		contents: ''
		font: (StrikeFont fontName: 'VerdanaBold' size: 10).
	column addMorph: titleMorph.
	self updateTitle.
	column addMorphBack: (Morph new color: column color; extent: 5@3).  "spacer"

	self removeAllMorphs.
	readouts _ readoutNames collect: [:i |
		(((i findString: 'Not connected') ~= 0) | ((i findString: 'LED') ~= 0) | ((i findString: 'Buzzer') ~= 0)) ifTrue: [
			kindOfSensor _ false.
		] ifFalse: [
			kindOfSensor _ true.
		].

		(i size = 1)
			ifTrue:[self addReadoutLabeled: i isSensor: kindOfSensor]
			ifFalse:[
				tmp _ i findTokens: ' '.
				header _ tmp at: 1.
				cont _ ''.
				2 to: (tmp size) do: [:index |
					cont _ cont, (tmp at: index).
					(index = tmp size) ifFalse: [cont _ cont, ' '].].
				self addReadoutLabeled: (header localized, ' ', cont localized) isSensor: kindOfSensor.]
	].

	" For Studuino mini "
	(BoardType = 1) ifTrue: [
		readouts add: (self addReadoutLabeled: 'Onboard LightSensor' localized).
		readouts add: (self addReadoutLabeled: 'Battery voltage [V]' localized).
		clock _ ColorClock new].

	column position: self position - 2.
	self addMorph: column.
	self extent: column extent - 4.

! !

	super initialize.
	sensorValues _ Array new: 16 withAll: 0.
	listTempBuf _ Array new: 8.
	currentState _ #idle.
	highByte _ 0.
	useGoGoProtocol ifNil: [useGoGoProtocol _ false].
	scratchBoardV3 _ false.
	reportRaw _ false.
	scanState _ #off.
	self addReadouts.
	disconnected _ false.
	retrySend _ 3.
	timeoutSend _ 50.
	resCommand _ 0.
	onSyncServo _ false.
	lockSend _ Semaphore forMutualExclusion.
	lockSync _ Semaphore forMutualExclusion.
! !
	"Update my title and sensor readouts. If scanning for ports, keep scanning."

	| frame i |
	(BoardType = 0) ifTrue: [

	#checkData = scanState ifTrue: [self scanForPort].
	self portIsOpen
		ifTrue: [self processIncomingData]
		ifFalse: [port _ nil.
"Transcript show: '[SensorBoardMorph::setp] port is nil';cr."
		].

	]
	ifFalse: [
		self socketIsOpen ifTrue: [
			self processIncomingData2]
		ifFalse: [
			port _ nil.
			Transcript show: 'sb socket is not open.'; cr.	].].

	self updateTitle.

"	1 to: 8 do: [:i |"
"	1 to: readouts size do: [:i |"
	readouts do: [:item |
		i _ readouts find: item.
		(BoardType = 1 &  i = (readouts size)) ifTrue: [  " Only for Studuino mini Battery Voltage. "
			item contents: (self privateSensor: i) printString]
		ifFalse: [
			item contents: (self privateSensor: i) printString].
		(scratchBoardV3 and: [i = 4])
			ifTrue: [(readouts at: i) contents: ((self privateSensor: i) < 10) printString]. "button"
		frame _ (readouts at: i) owner.
		(frame respondsTo: #fixLayout) ifTrue: [frame fixLayout]].

! !

	| val |
	val _ aValue.
	aValue > 127 ifTrue: [
		val _ aValue - 256].
	^ (val + 128) * 100 // 255
! !

	^ (((aValue / 1024) * 3.3) - 0.5) / 0.01! !
	"Process one byte of the incoming data stream from a Scratch sensor board."
	"Sensor messages are two bytes with the following format:
		Byte1: <1><sensor number (4 bits)><sensor value high bits (3 bits)>
		Byte2: <0><sensor value low bits (7 bits)>"

	| sensorNum val dtype isExtendedRead pos obj |
"
Transcript
show:'processScratchByte';cr.
"
	(aByte bitShift: -6) = 2 ifTrue: [
		dtype _ aByte bitAnd: 16r3F.
		dtype = 0 ifTrue: [	"ACK"
			resCommand _ 1].
		dtype = 1 ifTrue: [	"NACK"
			resCommand _ -1].
		dtype = 16r3F ifTrue: [	"syncFinish"
			onSyncServo _ false].
		^ self].

	"Extended data coming."
	isExtendedRead _ false.
	(aByte bitShift: -6) = 3 ifTrue: [
		isExtendedRead _ true].

	currentState = #idle ifTrue: [  "wait for first byte of message"
		(aByte bitShift: -6) = 0 ifTrue: [
			currentState _ #firstByteSeen.
			highByte _ aByte].
		^ self].

	currentState = #firstByteSeen ifTrue: [
		(aByte bitShift: -6) = 0 ifTrue: [  "must have lost second byte; stay in firstByteSeen state"
			highByte _ aByte.
			^ self].

		"good second byte: report the sensor value"
		sensorNum _ ((highByte bitShift: -2) bitAnd: 16rF) + 1.
		val _ ((highByte bitAnd: 3) bitShift: 6) + (aByte bitAnd: 16r3F).

		" Checking an extended data. "
		sensorNum <= 8 ifTrue: [
			(IOPort at: (10 + sensorNum)) = 16r18  "Temperature sensor"
				ifTrue: [
					isExtendedRead
						ifFalse: [
							secondByte _ aByte.
							^ self].
					val _ ((highByte bitAnd: 3) bitShift: 6) + (secondByte bitAnd: 16r3F).
					val _ val + ((aByte bitAnd: 16r3F) bitShift: 8)]].

(val = 128) ifTrue: [
"
Transcript
show:'[SensorBoardMorph::processScratchByte:] ';
show:sensorNum; show:', '; show:val;cr.
"
^ self.
].

		(val = 128) ifTrue: [ val _ 0. ].	" 128 is open port or output parts "
		
		(BoardType = 1) & (sensorNum = (readouts size)) ifTrue: [
			val _ (val / 10.0)].

		sensorNum <= sensorValues size ifTrue: [
			pos _ sensorNum.
			((sensorNum = 7 ) | (sensorNum = 8))
				ifTrue: [
					(readouts size ) > 8 ifTrue: [ pos _ sensorNum + 1]]. "A6/A7 position increment"
			sensorNum > 8
				ifTrue: [
					pos _ sensorNum - 4.  "Accelerometer readout position to 4/5/6"
					val _ self convertAccelerometer: val]
				ifFalse: [
					(IOPort at: (10 + sensorNum)) = 16r18
						ifTrue: [
							obj _ listTempBuf at: sensorNum.
							val _ (obj average: (self convertToCelcius: val)) asFloat.]].
			sensorValues at: pos put: val.
			sensorNum = 16 ifTrue: [
				(val == 3) | (val == 4) ifTrue: [
					scratchBoardV3 _ true]]].  "ScratchBoard, version 3 or 4"

		currentState _ #idle].
! !
	buffer _ Array new: size.
	currentPos _ 1.
	isRounded _ false.! !
	| sum last |
	isRounded
		ifTrue: [last _ buffer size]
		ifFalse: [
			currentPos = 1 ifTrue: [^ nil ].
			last _ currentPos - 1].
	sum _ 0.	
	1 to: last do: [:elm|
			sum _ sum + (buffer at: elm)].
	^ ((sum * 10 / last) truncated ) / 10
! !
	self init: (buffer size)! !

	buffer at: currentPos put: aValue.
	currentPos _ currentPos + 1.
	currentPos > buffer size ifTrue: [
		isRounded _ true.
		currentPos _ 1].! !
	"Answer a new instance of SharedQueue that has 10 elements."

	^self new: 10! !
	^super new init: anInteger! !
	"Answer a new instance of SharedQueue that has 10 elements."

	^super new init! !