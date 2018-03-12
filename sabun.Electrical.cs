'From MIT Squeak 0.9.4 (June 1, 2003) [No updates present.] on 16 November 2017 at 2:55:07 pm'!!EventHatMorph methodsFor: 'initialization' stamp: 'KK 11/16/2017 10:37'!forStartEvent	| t1 t2 t3 |	super initialize.	self removeAllMorphs.	t1 _ ScratchTranslator labelPartsFor: '%m Start'.	t2 _ StringMorph new contents: t1 first;			 font: (ScratchFrameMorph getFont: #Label);			 color: Color white.	self addMorphBack: t2.	t3 _ ImageMorph new form: (ScratchFrameMorph skinAt: #goButton).	self addMorphBack: t3.	t2 _ t2 fullCopy contents: t1 second.	self addMorphBack: t2.	scriptNameMorph _ EventTitleMorph new eventName: 'Scratch-StartClicked'.	self fixBlockLayout! !!ScriptableScratchMorph class methodsFor: 'block specs' stamp: 'KK 11/16/2017 10:29'!blockSpecs	"Answer a collection of block specifications for the blocks that are common to all objects. Block specificatons (Arrays) are interspersed with category names (Strings). A block specification is an Array of the form: (<block spec string> <block type> <selector> [optional initial argument values]).	Explanation of flags:		-	no flags		b	boolean reporter		c	c-shaped block containing a sequence of commands (always special form)		r	reporter		s	special form command with its own evaluation rule		t	timed command, like wait or glide		E	message event hat		K	key event hat		M	mouse-click event hat		S	start event hat		W	when <condition> hat (obsolete)"	| blocks |	blocks _ #(		'control'"			('%e function'			E	-)			('call %e function'			s	doBroadcastAndWait)			-"			('wait %n secs'					t	wait:elapsed:from: 1)			-			('forever'						c	doForever)			('repeat %n'						c	doRepeat 10)			-"			('broadcast %e'					-	broadcast:)			('forever if %b'					c	doForeverIf)"			('if %b'							c	doIf)			('if %b'							c	doIfElse)			('wait until %b'					s	doWaitUntil)			('repeat until %b'				c	doUntil)"			-			('stop script'					s	doReturn)			('stop all'						-	stopAll)""			('Servomotor synchro motion speed:%E'						c	doSvmSyncMotion2 10)		'compatible'			('Servomotor synchro motion delay:%E'						c	doSvmSyncMotion 10)"		'operators'			('%n + %n'						r	+ - -)			('%n - %n'						r	- - -)			('%n * %n'						r	* - -)			('%n / %n'						r	/ - -)"			-			('pick random %n to %n'		r	randomFrom:to: 1 10)"			-			('%n < %n'						b	< - -)			('%n = %n'						b	= - -)			('%n > %n'						b	> - -)			-			('%b and %b'					b	&)			('%b or %b'						b	|)			('not %b'						b	not)"			-			('join %s %s'					r	concatenate:with: 'hello ' 'world')			('letter %n of %s'				r	letter:of: 1 'world')			('length of %s'					r	stringLength: 'world')			-			('%n mod %n'					r	\\ - -)			('round %n'						r	rounded -)			-			('%f of %n'						r	computeFunction:of: 'sqrt' 10)"		'sound'"xxx			('play sound %S'				-	playSound:)			('play sound %S until done'		s	doPlaySoundAndWait)			('stop all sounds'				-	stopAllSounds)			-			('play drum %D for %n beats'	t 	drum:duration:elapsed:from: 48 0.2)			('rest for %n beats'				t 	rest:elapsed:from: 0.2)			-			('play note %N for %n beats'	t	noteOn:duration:elapsed:from: 60 0.5)			('set instrument to %I'			- 	midiInstrument: 1)			-			('change volume by %n'		- 	changeVolumeBy: -10)			('set volume to %n%'			- 	setVolumeTo: 100)			('volume'						r 	volume)			-			('change tempo by %n'			- 	changeTempoBy: 20)			('set tempo to %n bpm'			- 	setTempoTo: 60)			('tempo'							r 	tempo)"		'motor'"			('motor on for %n secs'			t	motorOnFor:elapsed:from: 1)			('motor on'						-	allMotorsOn)			('motor off'						-	allMotorsOff)			('motor power %n'				-	startMotorPower: 100)			('motor direction %W'			-	setMotorDirection: 'this way')			('Set servomotor %J to %F degrees'			-	motorNo:degree: 'PIN' 90)"			('Electrify M1 by %n %'			-	m1DCMotorOn: 100)			('Cut off electricity'				-	m1DCMotorOff)"			('Buzzer %B on frequency %N'	-	buzzerPin:freq: 'PIN' 60)			('Buzzer %B off'					-	buzzerPin: 'PIN')			('LED %p %o'					-	ledPin:onOff: 'PIN' 'on')"		'motion mini'			('Onboard LED %p1 %o'			-	boardLED:onOff: 'Red(D5)' 'on')			('Set time %nh %nm'			-	hour:min: 0 0)			('Set date %n/%n/%n'			-	month:day:year: 1 1 2016)			('Set alarm %nh %nm'			-	alhour:almin: 0 0)			('Set backlight R%n G%n B%n'	-	red:green:blue: 0 0 0)			('Backlight %o'					-	clkBackLight: 'on')			('Clock''s buzzer on frequency %N for %n'	t	clkBuzzerOnFreq:For:elapsed:from: 60 1)"			('Clock''s buzzer off'				-	clkBuzzerOff)""			('Color LED %w %o'				-	ledColor:onOff: 'White' 'on')"			-"			('Move %q for %n msec at %n power and %T'	-	direct:time:power:stop 'Forward' 100  100 'Brake')""			('Set servomotors %E ms/deg, D2:%F D4:%F D7:%F D8:%F D9:%F D10:%F D11:%F D12:%F' - setServoSpeed:d2:d4:d7:d8:d9:d10:d11:d12: 10 90 90 90 90 90 90 90 90)"			-		'variables'"			('show variable %v'				-	showVariable:)			('hide variable %v'				-	hideVariable:)"		'list'			('add %n to %L'					-	append:toList: 0)			-			('delete %y of %L'				-	deleteLine:ofList: 1)			('insert %n at %i of %L'			-	insert:at:ofList: 0 1)			('replace item %i of %L with %n'		-	setLine:ofList:to: 1 'list' 0)			-			('item %i of %L'					r	getLine:ofList: 1)			('length of %L'					r	lineCountOfList:)			('%L contains %n'				b	list:contains: 'list' 0)	).	^ blocks, self obsoleteBlockSpecs! !!ScratchStageMorph class methodsFor: 'block specs' stamp: 'KK 11/16/2017 10:31'!blockSpecs

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
			('set DC motor %j  %z'		-	motorNo:onOff: 'No.1' 'on')			('%z sensor value'			r	sensor: 'A0')
			('Light Sensor %P value'		r	lightSensor: 'PIN')			('Touch Sensor %V value'	r	touchSensor: 'PIN')
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