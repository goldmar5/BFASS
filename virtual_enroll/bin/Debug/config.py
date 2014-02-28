#!/usr/bin/python
# -*- coding: utf-8 -*-

import os
# automation port settings
AUTO_COM_PORT = "COM1"
AUTO_BAUD_RATE = 9600
# RF module port settings
SNIFFER_PORT = "COM2"
# panel sniffer port - 38400, detector port - 19200
SNIFFER_BAUD_RATE = 38400
# coronys repeater port settings,
# the com0com driver is used for retranslate data from automation port to coronys
CORONYS_PORT = "COM13"
CORONYS_BAUD_RATE = 9600

VERBOSE = 0
DEBUG_MODE = 1
LOG_FILENAME = os.path.abspath(os.path.dirname(__file__)) + "\\device.log"
BASE_PATH = os.path.abspath(os.path.dirname(__file__)) + "\\"

if __name__ == "__main__":
    pass

