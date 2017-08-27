# JAGBE
JAGBE or Just Another GameBoy Emulator for long, is exactly what it sounds like,
the goal of this emulator is to further learn how emulators work (maybe make something that will play more than tetris),
and to try not to stick everything in one file.

Currently passes the following of blargg's instruction tests:

|#|name|success?|
|-|-|-|
|01|special|:white_check_mark:|
|02|interrupts|:x:|
|03|op sp,hl|:x:|
|04|op r,imm|:white_check_mark:|
|05|op rp|:white_check_mark:|
|06|ld r,r|:white_check_mark:|
|07|jr,jp,call,ret,rst|:white_check_mark:|
|08|misc instrs|:white_check_mark:|
|09|op r,r|:white_check_mark:|
|10|bit ops|:white_check_mark:|
|11|op a,(hl)|:white_check_mark:|

|Memory Timing #|success?|
|-|-|
|1|:x:|
|2|:x:|
|3|:x:|

|name|success?|
|-|-|
|instr_timing|:x:|
