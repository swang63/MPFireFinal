# MissionPlanner

![Dot Net](https://github.com/ardupilot/missionplanner/actions/workflows/main.yml/badge.svg) ![Android](https://github.com/ardupilot/missionplanner/actions/workflows/android.yml/badge.svg) ![OSX/IOS](https://github.com/ardupilot/missionplanner/actions/workflows/mac.yml/badge.svg)

Website : http://ardupilot.org/planner/

Forum : http://discuss.ardupilot.org/c/ground-control-software/mission-planner

Download latest stable version : http://firmware.ardupilot.org/Tools/MissionPlanner/MissionPlanner-latest.msi

Changelog : https://github.com/ArduPilot/MissionPlanner/blob/master/ChangeLog.txt

License : https://github.com/ArduPilot/MissionPlanner/blob/master/COPYING.txt


## How to compile

### On Windows (Recommended)

#### 1. Install software

##### Main requirements

Currently, Mission Planner needs:

Visual Studio 2022

##### IDE

###### Visual Studio Community
The recommended way to compile Mission Planner is through Visual Studio.
You could do it with Visual Studio Community [Visual Studio Download page](https://visualstudio.microsoft.com/downloads/ "Visual Studio Download page").
Visual Studio suite is quite complex and comes with Git support. During the Selection phase, please goto More > import configuration, and use the file (https://raw.githubusercontent.com/ArduPilot/MissionPlanner/master/vs2022.vsconfig "vs2022.vsconfig")

###### VSCode
Currently VSCode with C# plugin is able to parse the code but cannot build.

#### 2. Get the code

If you get Visual Studio Community, you should be able to use Git from the IDE. 
Clone `https://github.com/ArduPilot/MissionPlanner.git` to get the full code.

In case you didn't install an IDE, you will need to manually install Git. Please follow instruction in https://ardupilot.org/dev/docs/where-to-get-the-code.html#downloading-the-code-using-git

Open a git bash terminal in the MissionPlanner directory and type, "git submodule update --init" to download all submodules

#### 3. Build

To build the code:
- Open MissionPlanner.sln with Visual Studio
- From the Build menu, select "Build MissionPlanner"

### On other systems
Building Mission Planner on other systems isn't support currently.

## Launching Mission Planner on other system

Mission Planner is available for Android via the Play Store. https://play.google.com/store/apps/details?id=com.michaeloborne.MissionPlanner
Mission Planner can be used with Mono on Linux systems. Be aware that not all functions are available on Linux.
Native MacOS and iOS support is experimental and not recommended for inexperienced users. https://github.com/ArduPilot/MissionPlanner/releases/tag/osxlatest 
For MacOS users it is recommended to use Mission Planner for Windows via Boot Camp or Parallels (or equivalent).

### On Linux

#### Requirements

Those instructions were tested on Ubuntu 20.04.
Please install Mono, either :
- `sudo apt install mono-complete mono-runtime libmono-system-windows-forms4.0-cil libmono-system-core4.0-cil libmono-winforms4.0-cil libmono-corlib4.0-cil libmono-system-management4.0-cil libmono-system-xml-linq4.0-cil`

#### Launching

- Get the lastest zipped version of Mission Planner here : https://firmware.ardupilot.org/Tools/MissionPlanner/MissionPlanner-latest.zip
- Unzip in the directory you want
- Go into the directory
- run with `mono MissionPlanner.exe`

You can debug Mission Planner on Mono with `MONO_LOG_LEVEL=debug mono MissionPlanner.exe`

### External Services Used

| Source | Use | How to disable | Custodian |
|---|---|---|---|
| https://firmware.oborne.me  | used as a global cdn for checking for MP update check - checked once per day at startup | edit missionplanner.exe.config | Michael Oborne |
| https://firmware.ardupilot.org  | used for updates to stable, firmware metadata, firmware, user alerts, gstreamer, SRTM, SITL | updates to stable (edit missionplanner.exe.config) - all others Not possible | Ardupilot Team |
| https://github.com/ | used for updates to beta | edit missionplanner.exe.config | Michael Oborne |
| https://raw.githubusercontent.com | old param metadata, sitl config files | Not possible | Ardupilot Team |
| https://api.github.com/ | ardupilot preload param files | Not possible | Ardupilot Team |
| https://raw.oborne.me/  | used as glocal cdn for parameter metadata generator, no longer primary source | only used at user request to regenerate, edit missionplanner.exe.config | Michael Oborne |
| https://maps.google.com  | used for elevation api - removed due to abuse | N/A | N/A |
| https://discuss.cubepilot.org/ | use for SB2 reporting - only on affected boards when user enters details | only used at user request | CubePilot |
| https://altitudeangel.com  | utm data - user enabled | only used at user request | Altitude Angel |
| https://autotest.ardupilot.org  | dataflash log meta data, parameter metadata | Not Possible | Ardupilot Team |
| Many | your choice of map provider google/bing/openstreetmap/etc | User selectable | User/Many |
| https://www.cloudflare.com | geo location provider - for NFZ selection | Not Possible | Michael Oborne |
| https://esua.cad.gov.hk | HK no fly zones - user enabled | User selectable | HK Gov |
| https://ssl.google-analytics.com | Google Analytics Anonymous Stats - Screen Loads, Exceptions/Crashs, Events (Connect), Startup Timing, FW upload (FW Type and Board Type) | disable in Config > Planner > OptOut Anon Stats | Michael Oborne |
| https://api.dronelogbook.com | logging - disabled | N/A | N/A |
| https://ardupilot.org | help urls on many pages | User Initiated | ArduPilot Team |
| https://www.youtube.com | help videos on many pages | User Initiated | ArduPilot Team |
| https://files.rfdesign.com.au | RFD firmwares | User Initiated | RFDesign |
| https://teck.airmarket.io | airmarket - disabled | N/A | N/A |

### Offline Use - No Internet

| Location | Use | Transferable between pcs |
|---|---|---|
| C:\ProgramData\Mission Planner\gmapcache | Map cache | yes |
| C:\ProgramData\Mission Planner\srtm | Elevation data cache | yes |
| C:\ProgramData\Mission Planner\\*.pdef.xml | Parameter cache | yes |
| C:\ProgramData\Mission Planner\LogMessages*.xml | DF Log metadata cache | yes |

on linux this is in /home/<user>/.local/share/Mission Planner/

### Offline Data Supported
#### Elevation
* SRTM Cache
* GeoTiff's in WGS84/EGM96
* DTED

#### Images
* Map Cache
* WMS
* WMTS
* GDAL

### Paths used - Default

| Location | Use |
|---|---|
| C:\ProgramData\Mission Planner | All cross user content |
| C:\Users\USERNAME\Documents\Mission Planner | All per user content |

on linux this is in /home/<user>/.local/share/Mission Planner/

### CA Cert
A CA cert is installed to the root store and used to sign the windows serial port drivers, and is installed as part of the MSI install.

[![FlagCounter](https://s01.flagcounter.com/count2/A4bA/bg_FFFFFF/txt_000000/border_CCCCCC/columns_8/maxflags_40/viewers_0/labels_1/pageviews_0/flags_0/percent_0/)](https://info.flagcounter.com/A4bA)


MISSION PLANNER FIRE CHANGES
Software Code Parameters utilized for running the software. The parameters below are viewable through on the Plan UI page as indicated by the photo below.

Downloadable packaged executable is available here

Planner UI

Window: This value determines the size of the window of fire files to keep displayed on the map. This window refers to each of the fire map “LOC######.TXT” where the number corresponds to a particular second of the fire as observed by the UAV. The window thereby is set in seconds from last file to display. 300 seconds or 5 minutes is set as the default value

Update: This value will update and reload the fireMap upon the number of files loaded. Default value is set to 10. This will update the map for values of time since last visit metrics for display.

Filter Value: This value is set to 0.001 by default. This value is the measure in degrees. This filter value will include files of numerical order if the average latitude and longitude difference between the files is less than this value. This will remove files in which the projected fire map appears to “jump” a far distance. Files that have no preceding location file will be ignored so if there is a jump in the number of the location file. The subsequent files will NOT be filtered.

Last Visit: This will display fire files that exceed the time since the last visit in a green color. This parameter is set in seconds and is defaulted to 60 seconds.

Grid Size: This is the size in which the data is discretized from the fire files. Default grid size is set to 500x500. If there are issues with lag regarding the map interface and number of markers.

Grid Max: This is the size of the box that bounds the fire values within a grid for discretization of the fire shape. The grid max size is in meters and will produce a box of this size for bounding the fire shape. A UI message box will occur indicating that fire points have been detected outside of the grid max. In this instance, please increase the paramater to allow for the full fire shape to fit.

Running the software
Fire Toolbar

Steps to run the software are below

Select the Plan Tab
Choose the parmaeters for viewing the fire files. The default values are shown in the figure above.
Click the Toggle Grid button to toggle the maximum grid size of the fire shape.
Click the Load Fire Folder Button. This will allow you to select the directory for where the fire files are located. If files are added to this directory, they will automatically upload and display new information every 30 seconds.
Click the Stop Reading button to stop reading new incoming files.
The map displays the inner boundary of the fire shape with a yellow X, the average fire shape value from the last 5 values taken for that angle in a blue shape, and the outer boundary of the fire with a white X.
