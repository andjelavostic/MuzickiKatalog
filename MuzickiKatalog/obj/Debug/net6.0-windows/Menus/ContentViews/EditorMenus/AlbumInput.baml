   M S B A M L   `   `   `  ����I  EMuzickiKatalog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullm;clr-namespace:MuzickiKatalog.Menus.ContentViews.EditorMenus-MuzickiKatalog.Menus.ContentViews.EditorMenus  5   	   >    8MuzickiKatalog.Menus.ContentViews.EditorMenus.AlbumInput   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Mlocal;clr-namespace:MuzickiKatalog.Menus.ContentViews.EditorMenus     5   	     � Title$  
AlbumInput��5   	   
������$	��770��64   $	��462��6A   .��5	      � $��0,0,0,-6q�6   .+�5
   
   �� $��Name of the album: ��6   $
��Left=�6.   $��	34,22,0,0q�6I   $	��Top=�6\   $	��123��6t   �� 5   
   $��Artist:��6   $
��Left=�6"   $��	34,68,0,0q�6=   $	��Top=�6P   $	��113��6h   �� 5   
   $��Select image:��6   $
��Left=�6(   $��
34,148,0,0q�6C   $	��Top=�6W   $	��113��6o   �� 5   
   $��Select genres:��6   $
��Left=�6)   $��
34,240,0,0q�6D   $	��Top=�6X   $	��102��6p   �� 5   
   -   5        $��nazivAlbumaText��5      $
��Left=�6)   $��
231,26,0,0q�6D    �� TextWrapping$
 Wrap=�6X   $�� ��6l   $	��Top=�6t   $	��177��6�   $��22��6�   �� 5   
   -   5        $��imageLinkText��5      $
��Left=�6'   $��229,152,0,0q�6B   $
 Wrap=�6W   $�� ��6k   $	��Top=�6s   $	��179��6�   $��24��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   .��6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 0.637Q�6&   T� 5      5      .��5   '   5      �� 5   
   -   5        $��chooseGenreList��5       �� SelectionMode$ Multiple=�6)   $��231,236,54,431q�6m   �� 5   
   $��Enter the description:��6   $
��Left=�61   $��
40,355,0,0q�6L   $	��Top=�6`   $	��124��6x   $ 0.488,0.156&�6�   �� 5   
   $��231,355,54,329q�6   . �5      /� .T�5      J� .*�6   .*�5      �� -   5         �Name$ opisText��5      $� ��6*   5      5       5!      �� 5"   
   -   5        $��artistCombo��5"      $
��Left=�6V   $��
231,70,0,0q�6q   $	��Top=�6�   $	��177��6�   $��24��6�   �� 5#   
   -   5        $��	addButton��5#      $	��Add��6;   $��Center=�6I   $��	0,683,0,0q�6f   $	��Top=�6y   $��40��6�   $	��112��6�   �� 5$   
   $��Record label:��6   $
��Left=�6(   $��
34,192,0,0q�6C   $	��Top=�6W   $	��102��6o   �� 5%   
   -   5        $��izdavackaText��5%      $
��Left=�6'   $��231,196,0,0q�6B   $
 Wrap=�6W   $�� ��6k   $	��Top=�6s   $	��177��6�   $��22��6�   �� 5&   
   $��Album type:��6   $
��Left=�6&   $��
34,107,0,0q�6A   $	��Top=�6U   $	��113��6m   �� 5'   
   -   5        $��tipCombo��5'      $
��Left=�6#   $��231,109,0,0q�6>   $	��Top=�6S   $	��177��6k   $��24��6w   �� 5(   
   $��Choose tracks��6   $
��Left=�6(   $��
46,461,0,0q�6C   $	��Top=�6W   $	��124��6o   $ 0.488,0.156&�6{   �� 5)   
   -	   5        $��trackChoiceList��5)      $ Multiple=�6)   $��231,457,54,224q�6m   �� 5*   
   $��Review��6   $
��Left=�6!   $��30��6<   $��
46,569,0,0q�6H   $	��Top=�6\   $	��111��6t   �� 5+   
   $��Grade��6   $
��Left=�6    $��29��6;   $��
46,623,0,0q�6G   $	��Top=�6[   $	��111��6s   �� 5,   
   -
   5        $��
reviewtext��5,      $
��Left=�6$   $��48��6?   $��231,560,0,0q�6K   $
 Wrap=�6`   $	��Top=�6u   $	��177��6�   �� 5-   
   -   5        $��
gradeCombo��5-      $
��Left=�6%   $��29��6@   $��231,625,0,0q�6L   $	��Top=�6a   $	��177��6y   5.      5/      