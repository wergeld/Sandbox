/*
  DoorSensor.h - Library for checking door status.
  Created by LRichards, June 10, 2014.
  Released into the public domain.
*/

#ifndef DoorSensor_h
#define DoorSensor_h

#include "Arduino.h"

class Door
{
  public:
    Door(int pin);
    void isAvailable();
    int _pin;
};

#endif
