   M S B A M L   `   `   `  ���� K  GGetReport, Version=0.1.6705.18589, Culture=neutral, PublicKeyToken=null1clr-namespace:GetReport.ViewsGetReport.Views  #    GetReport.Views.ReportOSRView   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:GetReport.Views     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � 	Resources     ComboBoxTmp �� Orientation �� Path��%�   &	        �� .R��� $ 
Horizontal=�.+��� {�.  ���� $ 	FirstName��� {�.  ���� $ LastName��� {�.  ���� $
 Post�.���� -    ��Name$	 st1��$	��Top=�$ Vertical=�.+�9� -    9�Name$
 Exp1��$Q��KНаименование объекта и реквизиты сторон:�� 9� 
IsExpanded ��  �� ElementName$ Expand1��$ 	IsChecked�.���� .+��� $	��290��$F��@Объект капитального строительства��$
��Wrap=��� -    ��Name$ nameAndAddressOfObject��$	��290��$	��1,1q� �� TextWrapping$
 Wrap=�"	 �� VerticalScrollBarVisibility$
	 Auto=����� $ NameAndAddressOfObject�
 �� Mode$
 TwoWay=��� $	��290��$I��CЗастройщик или технический заказчик��$
��Wrap=��� -   $ requisitesOfConsumer��$	��290��$	��1,1q�$
 Wrap=�$
	 Auto=����� $ RequisitesOfConsumer�$
 TwoWay=��� $	��290��$G��AЛицо, осуществляющее строительство��$
��Wrap=��� -   $! requisitesOfPrimeContractor��$	��290��$	��1,1q�$
 Wrap=�$
	 Auto=����� $! RequisitesOfPrimeContractor�$
 TwoWay=��� $	��290��$P��JЛицо, осуществляющее подготовку проекта��$
��Wrap=��� -   $" requisitesOfProjectDeveloper��$	��290��$	��1,1q�$
 Wrap=�$
	 Auto=����� $" RequisitesOfProjectDeveloper�$
 TwoWay=��� $	��290��$3��-Лицо, выполнившее работы��$
��Wrap=��� -   $ requisitesOfBuilder��$	��290��$	��1,1q�$
 Wrap=�$
	 Auto=����� $ RequisitesOfBuilder�$
 TwoWay=��� $	��290��$��Номер акта��$
��Wrap=��� -   $ numberOfReport������ $ NumberOfReport�$
 TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� $	��290��$,��&Дата подписания акта��$
��Wrap=�(  "System.Windows.Controls.DatePicker  -	     Name$ dateOfPreparationOfReport��   Text �� $ DateOfPreparationOfReport�$
 TwoWay=�9� -
   $
 Exp2��$-��'Представители сторон�� �� $ Expand2��$ 	IsChecked�.���� -   $	 st2��.+��� $	��290��$W��QПредставитель застройщика или техзаказчика��$
��Wrap=��� -    ��Name$ delegateOfConsumer��$��1q�#��[  ���� *session.ListOfMember+ �� SelectedItem �� *DelegateOfConsumer+$
 TwoWay=��� $	��290��$d��^Представитель лица, осуществляющего строительство��$
��Wrap=��� -   $ delegateOfPrimeContractor��$	��1,1q�#��[   �� $ DelegateOfPrimeContractor�$
 TwoWay=�$ PropertyChanged=��� $	��290��$����Представитель лица, осуществляющего строительство по вопросам строительного контроля��$
��Wrap=��� -   $+ %delegateOfBuildControlPrimeContractor��$	��1,1q�#��[   �� $+ %DelegateOfBuildControlPrimeContractor�$
 TwoWay=�$ PropertyChanged=��� $	��290��$����Представитель лица, осуществляющего подготовку проектной документации��$
��Wrap=��� -   $  delegateOfProjectDeveloper��$	��1,1q� �� $  DelegateOfProjectDeveloper�$
 TwoWay=�$ PropertyChanged=��� $	��290��$����Представитель лица, выполнившего работы, подлежащие освидетельствованию��$
��Wrap=��� -   $ delegateOfBuilder��$	��1,1q�#��[   �� $ DelegateOfBuilder�$
 TwoWay=�$ PropertyChanged=��� $	��290��$0��*Иные представители лиц��$
��Wrap=��� -   $ delegateOfOtherCompany��$	��1,1q�#��[   �� $ DelegateOfOtherCompany�$
 TwoWay=�$ PropertyChanged=��� $	��290��$2��,Иные представители лиц 2��$
��Wrap=��� -   $ delegateOfOtherCompany2��$	��1,1q�#��[   �� $ DelegateOfOtherCompany2�$
 TwoWay=�$ PropertyChanged=��� $	��290��$2��,Иные представители лиц 3��$
��Wrap=��� -   $ delegateOfOtherCompany3��$	��1,1q�#��[   �� $ DelegateOfOtherCompany3�$
 TwoWay=�$ PropertyChanged=�9� -   $
 Exp3��$#��Основные данные�� �� $ Expand3��$ 	IsChecked�.���� .+��� $	��290��$f��`К освидетельствованию предъявлены следующие работы��$
��Wrap=��� -   $ workName��$	��290��$	��1,1q�$
 Wrap=�$
	 Auto=����� $ WorkName�$
 TwoWay=��� $	��290��$���}Работы выполнены в соответствии с разделами проектной документации��$
��Wrap=��� -   $ projectTheWorkIncluded��$	��290��$	��1,1q�$
 Wrap=�$
	 Auto=����� $ ProjectTheWorkIncluded�$
 TwoWay=��� $	��290��$?��9При выполнении работ применены��$
��Wrap=��� -   $ TheListOfMaterial��$	��290��$	��1,1q�$
 Wrap=�$
	 Auto=����� $ TheListOfMaterial�$
 TwoWay=��� $	��290��$����Предъявлены документы, подтверждающие соответствие работ предъявляемым к ним требованиям��$
��Wrap=��� -   $" TheListOfQuantityConsistDocs��$	��290��$	��1,1q�$
 Wrap=�$
	 Auto=����� $" TheListOfQuantityConsistDocs�$
 TwoWay=��� $	��290��$&�� Дата начала работ��$
��Wrap=�  -   $ dateOfWorkStart��$	��290�� �� $ TheDateOfWorkStart�$
 TwoWay=��� $	��290��$,��&Дата окончания работ��$
��Wrap=�  -   $ dateOfWorkEnding��$	��290�� �� $ TheDateOfWorkEnding�$
 TwoWay=��� $	��290��$A��;Работы выполнены в соответствии��$
��Wrap=��� -   $ listOfDocumentConsists��$	��290��$	��1,1q�$
 Wrap=�$
	 Auto=����� $ TheListOfDocumentConsists�$
 TwoWay=��� $	��290��$W��QРазрешается производство последующих работ���� -   $ nextWorkIsAccepted��$	��290��$	��1,1q�$
 Wrap=�$
	 Auto=����� $ TheNextWorkIsAccepted�$
 TwoWay=��� $	��290��$��Приложения��$
��Wrap=��� -   $ annexes��$	��290��$	��1,1q�$
 Wrap=�$
	 Auto=����� $ Annexes�$
 TwoWay=�