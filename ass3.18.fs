: gcd ( a b -- d )
  2dup < if swap endif ( x y -- max min )
  begin
  2dup mod 0<> while ( a b -- b a%b while a%b<>0 )
    tuck mod
  repeat
  nip ;

64 56 gcd .
