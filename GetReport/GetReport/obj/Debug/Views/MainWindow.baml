   M S B A M L   `   `   `  ����K  GGetReport, Version=0.1.6705.23882, Culture=neutral, PublicKeyToken=null1clr-namespace:GetReport.ViewsGetReport.Views  5           GetReport.Views.MainWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:GetReport.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  	GetReport��5      $
��1024��5	      $	��600��5
       � WindowState$ Normal=�5       � 	Resources 5         ReportListTemplateAOSR  LVStyle �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value��%|  &	        &	 (     �� 5   
   .R�5      �� 5      �� 5   
   " ��6    .�5      ��  � ��
 ��İ�6+   �� 5       � ��$ 5q�6'   �� 5       � ��$ 5q�6(    5      P� 5       �@��
IsSelected . . �5      ��  � ��
 �����63   �� 5       � ��$ 1q�68   �� 5       � ��
 �   �64   5      5      5      	 J� InputBindings	 5      �� 5!   
   

 �� Key$
 S��5"       �� 	Modifiers$
 Ctrlf�5$       �� Command 5#      �� *	SaveCmd+5$      �� 5%   
    �� Gesture$ Ctrl+Shift+S��63    6   �� *	SaveAsCmd+63   �� 5&   
   $ Ctrl+O��61    6   �� *	OpenCmd+61   �� 5'   
   $ Ctrl+N��60    6   �� *NewCmd+60   �� 5(   
   $ Alt+F4��61    6   �� *	ExitCmd+61   .��5+      ]� .+�5,   
   +  %System.Windows.Controls.Ribbon.Ribbon  -   5          Name$ 	RibbonWin��5-      ���	#FFF1F1F1���	#FFC9C9C9$	��Top=�50       �� SelectedIndex$ 0��51         HelpPaneContent 53      1  +System.Windows.Controls.Ribbon.RibbonButton  54      -   5        $��About��56         SmallImageSource$ Images\info.png��57         QuickAccessToolBar 5:      =  7System.Windows.Controls.Ribbon.RibbonQuickAccessToolBar  5;      .@�5<        -   5          Name$
 Save��5=      $ Images\save.png��5?      {�5>      �� *SaveSessionE+5?      5I         ApplicationMenu 5L      :  4System.Windows.Controls.Ribbon.RibbonApplicationMenu  5M      
���   �5  /System.Windows.Controls.Ribbon.RibbonMenuButton   KeyTip$ F��6;   .@�5N      >  8System.Windows.Controls.Ribbon.RibbonApplicationMenuItem  -   5        $	��New��5P       m� InputGestureText$ Ctrl+N��5Q      {�5R      �� *NewSessionE+  5S      -   5        $
��Open��5U      $ Ctrl+O��5V      {�5W      �� *OpenSessionE+  5X      -   5        $
��Save��5Z      $ Ctrl+S��5[      {�5\      �� *SaveSessionE+  5]      $��Save As��5_      $ Ctrl+Shift+S��5`       m� Command 5^      �� *	SaveAsCmd+{�5a      �� *SaveAsSessionE+4  .System.Windows.Controls.Ribbon.RibbonSeparator  5b      m� 5c      $
��Exit��5e      $ Alt+F4��5f       5d      �� *	ExitCmd+5f      5g      .@�5j      .  (System.Windows.Controls.Ribbon.RibbonTab  $
��Home��6      KeyTip$ H��6&   .@�5l      0	  *System.Windows.Controls.Ribbon.RibbonGroup	  -   5         	 Name$ ClipboardGroup��5l      $
��Home��66   .@�5m        -   5           KeyTip$ N��5p         Label$	 New��5q         LargeImageSource$ Images\document.png��5r      {�5o      �� *NewSessionE+5r        5s      -	   5        $ O��5v      $
 Open��5w      $ Images\folder.png��5x      {�5u      �� *OpenSessionE+5x        5y      -
   5        $ S��5|      $
 Save��5}      $ Images\save.png��5~      {�5{      �� *SaveSessionE+5~      5      	  5�      -   5        $ Report��5�      $��Report��6.   .@�5�        -   5        $ A��5�      $ 
Add report��5�      $ Images\plus.png��5�      {�5�      �� *AddReportToListE+5�        5�      -   5        $ D��5�      $ Delete selected��5�      $ Images\delete.png��5�      {�5�      �� *DeleteReportFromListE+5�      3
  -System.Windows.Controls.Ribbon.RibbonCheckBox
  5�      -   5         
 Name$ Expand1��5�   %   $
��Lev1��5�      
  5�      -   5        $ Expand2��5�   %   $
��Lev2��5�      
  5�      -   5        $ Expand3��5�   %   $
��Lev3��5�        5�      $ R��5�      $ Copy to Right��5�      $ Images\Right.png��5�      ��5�      �� *!GetCreateNewReportInListCommand+5�        5�      $ R��5�      $ Copy to Right��5�      $ Images\Left.png��5�      ��5�      �� *!GetCreateNewReportInListCommand+5�      5�      	  5�      -   5        $ Export��5�      $��Publish��6.   .@�5�        -   5        $ P��5�      $ Publish��5�      $ Images\word.png��5�        5�      $ D��5�      $ 	Delegates��5�      $ Images\briefcase.png��5�      ��5�      �� *ShowDelegateListDialogCmd+5�      5�      5�      5�      �� 5�   
   -   5         ��Name$ scvwr��5�      .��5�      �� -   5         ��Name$ sessionReportList��5�      $��Stretch=�5�      $	��Top=�5�      #��[ 5�      ��5�      �� 5�      .R�5�      �� $
��Left=�5�      $	��Top=�5�        �� Orientation$  
Horizontal=�5�      5�      ��5�      �� 5�      .R�5�      #   GetReport.Views.ReportOSRView  5�      5�      5�      �� 5�   
   $��15��5�      $��Bottom=�5�      $��Bottom=�5�      $��Bottom=�5�      .@�5�      �� $��	StatusBar��6   5�      5�      5�      