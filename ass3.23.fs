: vsum ( addr u -- n )
  { addr u }
  0 u 1- 0 u+do
    addr i cells + @ +
  loop ;

create v 1 , 2 , 3 , 4 , 5 , 6 , 7 , 8 , 9 , 10
v 10 vsum .
