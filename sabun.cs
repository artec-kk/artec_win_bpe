'From MIT Squeak 0.9.4 (June 1, 2003) [No updates present.] on 24 April 2017 at 10:12:29 am'!

	| curPosition |
	targetField contents: lastContents.
	((aValue = 46) not & lastContents = '0') ifTrue: [
		targetField selectAll].

	targetField insertCharacter: aValue.
	curPosition _ targetField cursorPosition.
	World activeHand newKeyboardFocus: targetField.
	targetField moveCursorAt: curPosition.
! !