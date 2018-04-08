#!/bin/bash
cd ${0%/*}
RW_PATH="/f/Program Files (x86)/Steam/steamapps/common/RimWorld"
cp --verbose -rf ../TheCapital/bin/Debug/TheCapital.dll ../TheCapital/Mod/Assemblies/
cp --verbose -rf ../TheCapital/Mod/* "$RW_PATH/Mods/TheCapital"
