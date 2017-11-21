# wpf-task-manager
Simple task manager for Windows, utilizing the System.Process class and WPF.

### Original requirements
POL:
```
Aplikcja powinna zostac zrealizowana w WPF i prezentowac liste procesow w sytemie. Prosze zastosowac wzorzec Master/Detail.
Dla wybranego procesu w sekcji szczegoly powiny byc prezentowane mozliwie wszystkie dostepne informacje np. pamiec (z ew. podzialem na rdzaje), priorytet, lista watkow, lista modulow (im wiecej tym lepiej).
Aplikcja powinna wykorzystywac mozliwosci klasy process i umozliwiac interakcje z wybranym procesem np. zabicie, zmiane priorytetu itd.
Odswiezanie listy procesow powinno miec miejsce na zyczenie/co zadany okres czasu (problem: co zrobic zeby lista nie migala?)
Aplikacja dodatkowo po wskazaniu procesu/procesow powinna zapewnic ciaglosc dzialania zaznaczonych procesow, tj. po zakonczeniu uruchamiac go/je ponownie (problem jak okreslic parametry uruchomieniowe procesu tak by po restarcie zostal uruchomiony z odpowiednimi prarametrami).
```
ENG:
```
The application should be implemented in WPF and present a list of processes in the system. Please use Master/Detail pattern.
For the selected process, the detail section should contain all the available information, such as memory, priority, list of threads, list of modules (the more the better).
The application should use the process class and allow interaction with the selected process, such as killing, changing priority, and so on.
Refreshing the list of processes should take place on demand/after every specified time period (problem: how to prevent the list from flashing?)
Additionally, after selecting the process/processes, the application should ensure the continuity of the selected processes, ie after restart it/them after they are closed (problem how to specify startup parameters after restart).
```
