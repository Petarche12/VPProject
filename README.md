# VPProject
Windows forms project made by Petarche Lazarevski and Kristijan Donevski

1.Краток опис

Апликацијата која ја изработивме за овој проект е игра која треба да го привлече вниманието на играчот поради својата
едноставност за играње која би можело да ја разбере и мало дете. Главната мотивација за изработката на оваа игра ни
беше мега популарната игра flappy bird.

Со цел да обезбедиме комплетно задоволство кај играчот, покрај чистиот и едноставен дизајн, имлементиравме интересен начин на
развој на играта така што тежината на играње ке се зголемувуа полека со текот на времето, исто така после секоја завршена игра 
се зачувува постигнатиот резултат на играчот.

2.Упатство за играње

На почетниот прозорец (слика 1) при стартување на апликацијата имаме можност да започнеме нова игра (Play),
да ja видиме листа со рекорди (Show Stats) и копче за излез од играта (Exit) при што автоматски се зачувуваат новите податоци.

-2.1 Play(Button)

  Доколку сакаме да започнеме нова игра тоа го правиме на едноставен начин со притискање на копчето Play, исто така по завршување
  на играта се појавува прозорец каде треба да се внесе името на играчот и да се избере една од двете опции New Game или Main Menu.
  
-2.2 Show Stats(Button)

  Тука sе чуваат најдобрите 5 играчи, сортирани според постигнатиот резултат при завршување на играта.
  
-2.3 Exit(Button)

  Ова е едноставно копче за излез од играта при што во позадина со при кликање на копчето освен што се затвора играта се 
  најпрвин се зачувуваат новите податоци за постигнатите резултати во text file, при што тие потоа при повторно вклучување на играта
  се вчитуваат за во Load Form event.
  
3.Цел на играта

Целнта во оваа игра е да се постигне што поголем резултат, со тоа што како поминува времето тежината за играње се зголемува.
Зголемувањето на тежината е овозможено од тоа што на почетокот имаме само неколку пречки на ѕидовите поточно една и те се зголемуваат се  до максимум 7 пречки(spikes). Исто така по некое време се појавува и облак кој најпрвин се затемнува како предупредување и по некое времеизлегува грмотевица од него која може да ја убие птицата.
