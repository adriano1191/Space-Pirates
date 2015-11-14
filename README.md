# Space-Pirates

Domyslna hierarchia na scenie

Nazwa | Z Position | Opis
------| -----------|-----
GUI   |    0       |Wszystkie elementy zwiazane z interfejsem 
Level |0           |Poziomy na scenie
Level \ 0 - Background| 10 | Elementy dalekiego tła
Level \ 1 - Middleground | 5 | Elementy bliskiego tła ale ktore NIE wchodza w kolizje z Graczem itp
Level \ 2 - Foreground | 0 | Elementy na scenie które mogą wchodzic w kolizje z graczem takie jak przeciwnicy lub przeszkody
Render | 0 | Wszystkie pozostałe takie jak kamera, światła itp.

![hierarchia](/Hierarchia.jpg)
	
