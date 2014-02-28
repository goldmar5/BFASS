#!/usr/bin/env python
# -*- coding: utf-8 -*-

import sys
import config
import serial
from pmax.controller import Controller
from pmax.communicator import Communicator
import common.log



if __name__ == "__main__":

    common.log.open(config.LOG_FILENAME)
    SnifferCommunicator = None
    # Added for usage with 1 COM port
    try:
        AutoCommunicator = Communicator(config.AUTO_COM_PORT, config.AUTO_BAUD_RATE, "AUTO")
    except serial.SerialException:
    #   AutoCommunicator = None
        print "Can't open automation port " + config.AUTO_COM_PORT
        sys.exit()
    
    if config.DEBUG_MODE:
        try:
            SnifferCommunicator = Communicator(config.SNIFFER_PORT, config.SNIFFER_BAUD_RATE, "RF", config.CORONYS_PORT, config.CORONYS_BAUD_RATE)
        except serial.SerialException:
            print "Can't open sniffer port " + config.SNIFFER_PORT
    else:
        try:
            SnifferCommunicator = Communicator(config.SNIFFER_PORT, config.SNIFFER_BAUD_RATE, "RF")
        except Exception ,e:
            print "Can't open sniffer port " + config.SNIFFER_PORT
            #print e.message

    Controller = Controller(AutoCommunicator, SnifferCommunicator)
    common.log.close()
    sys.exit()
