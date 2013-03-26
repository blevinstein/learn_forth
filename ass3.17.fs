: min ( a b -- m )
  { a b }
  a a b < and
  b b a < and
  + ;

2 3 min .
3 2 min .
