'From MIT Squeak 0.9.4 (June 1, 2003) [No updates present.] on 16 November 2017 at 2:55:07 pm'!

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