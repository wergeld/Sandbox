/*
  DoorSensor.cpp - Library for checking status of door.
  Created by LRichards, June 10, 2014.
  Released into the public domain.
*/

#include "Arduino.h"
#include "DoorSensor.h"

DoorSensor::DoorSensor(int pin)
{
  pinMode(pin, OUTPUT);
  _pin = pin;
}

void DoorSensor::isAvailable()
{
  digitalWrite(_pin, HIGH);
  delay(250);
  digitalWrite(_pin, LOW);
  delay(250);  
}
