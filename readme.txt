########################################
#      ____              __            #
#     / __ \   ____ _   / /      ___   #
#    / / / /  / __ `/  / /      / _ \  #
#   / /_/ /  / /_/ /  / /___   /  __/  #
#  /_____/   \__,_/  /_____/   \___/   #
#    WINDOWS LOCKSCREEN DOWNLOADER     #
########################################

created 15/04/2016

Decription: copy all lockscreen pictures in the windows asset folder (*) to
            a dedicated folder (**) in your pictures folder

Notes: > all copied files are given a jpg extension (original files are without
         extension)
       > only files with dimension 1920*1080 are copied (to ensure only
         backgrounds are copied)

Use:
    either trust and
        > download the raw exe file (just run it or create a shortcut and place
          the shortcut in your startup folder to 'automate' the process)
    or be cautious (and willing to work) and
        > create your own project in Visual Studio , use the code from the
          textfile sourcode.txt , all used resources are in the resources
          folder. Use and change at your own convenience.



(*) C:\Users\<User>\AppData\Local\Packages\ Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\LocalState\Assets\
(**) C:\Users\<User>\Pictures\Windows Lockscreens\
