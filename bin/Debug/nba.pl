:-dynamic klub/2.
:-dynamic igrac/2.


dodajIgraca(X,Y) :- asserta(igrac(X,Y)).
obrisiIgraca(X) :- retract(igrac(X,_)).

dodajKlub(X) :- asserta(klub(X)).
obrisiKlub(X) :- retract(klub(X)).

postojiDatoteka :- exists_file('nba - Copy.pl'), consult('nba - Copy.pl').
zatvoriDatoteku :-tell('nba - Copy.pl'), listing(klub), listing(igrac), told.