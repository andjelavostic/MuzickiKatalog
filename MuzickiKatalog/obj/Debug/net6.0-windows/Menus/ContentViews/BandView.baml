   M S B A M L   `   `   `  ����I  EMuzickiKatalog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:MuzickiKatalog.Menus.ContentViews!MuzickiKatalog.Menus.ContentViews  5   	   0    *MuzickiKatalog.Menus.ContentViews.BandView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:MuzickiKatalog.Menus.ContentViews     5   	     � Title$  BandView��5   	   
������$	��981��62   $	��953��6?   .��5	      � $��0,0,0,-6q�6   .+�5
   
   �� $��/Images/sadrzaj.png��6   $
��Left=�6.   $	��200��6I   $��
483,46,0,0q�6V   $	��Top=�6j   $	��200��6�   �� 5   
   -   5        $��DesctiptionTextBlock��5      $
��Left=�61   $��
61,108,0,0q�6L   $
��Wrap=�6`   $W��QTextBlock (opis i karakteristike tj izvodjac numere zanr i slicno za dat sadrzaj)��6t   $	��Top=�6�   $	��145��6�   $	��324��6�   �� 5   
   $��Description:��6   $
��Left=�6'   $��	61,58,0,0q�6B   $	��Top=�6U   $	��124��6m   �� 5   
   -   5        $��userRatingLabel��5      $��User rating: ��6'   $
��Left=�6?   $��394,327,0,0q�6Z   $	��Top=�6o   $	��122��6�   �� 5   
   -   5        $��editorsRatingLabel��5      $��Editor rating: ��6*   $
��Left=�6D   $��394,285,0,0q�6_   $	��Top=�6t   $	��122��6�   �� 5   
   $��Leave your rating:��6   $
��Left=�6-   $��
61,272,0,0q�6H   $	��Top=�6\   $	��114��6t   �� 5   
   -   5        $��ratingComboBox��5      $
��Left=�6)   $��194,276,0,0q�6D   $	��Top=�6Y   $��47��6q   �� 5   
   -   5        $��ratingButton��5      $
��Rate��6@   $
��Left=�6O   $��34��6j   $��
61,319,0,0q�6v   $	��Top=�6�   $��81��6�   �� 5   
   $��Leave your review: ��6   $
��Left=�6.   $��
61,390,0,0q�6I   $	��Top=�6]   �� 5   
   -   5        $��reviewTextBox��5      $
��Left=�6+   $��83��6F   $��
61,444,0,0q�6R   $	��Top=�6f   $	��248��6~    J� RenderTransformOrigin$ 0.425,0.142&�6�   . �5      /� .T�5      J� .*�6   .*�5      �� $� ��6   5      5      5      �� 5   
   -   5        $��reviewButton��5      $��Review��6@   $
��Left=�6Q   $��34��6l   $��
61,555,0,0q�6x   $	��Top=�6�   $��81��6�   �� 5   
   $��Editor's review:��6   $
��Left=�6+   $��394,389,0,0q�6F   $	��Top=�6[   �� 5   
   -   5        $��editorsReviewTextBlock��5      $
��Left=�62   $��394,444,0,0q�6M   $
��Wrap=�6b   $��(Recenzija urednika)��6v   $	��Top=�6�   $	��145��6�   $	��283��6�   �� 5   
   -	   5        $��Back to homepage��5      $
��Left=�6,   $��760,108,0,0q�6G   $	��Top=�6\   $��56��6t   $	��142��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -
   5        $��discographyDataGrid��5         AutoGenerateColumns$ False��6.   $��61,688,568,61q�6b   ��6J   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+  5!      $ Naziv��6%    64   �� *Naziv+  5"      $ Zanrovi��6%      
IsReadOnly$
 True��5#       5"   6   �� *	Zanrovi+5$      5&      �� 5'   
   $��Discography:��6   $
��Left=�6'   $��
61,657,0,0q�6B   $	��Top=�6V   $	��204��6n   5(      5)      