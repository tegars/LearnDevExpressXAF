;#DropDB LearnXAFEasyTest

#Application LearnXAF.Win
#Application LearnXAF.Web
#IfDef LearnXAF.Win

*Action About...
 
*Action OK

#EndIf

#IfDef LearnXAF.Web
!Action Navigation(My Details)
#EndIf
