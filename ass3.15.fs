1 2 nip .s drop
1 2 tuck .s drop drop drop
5 2 /mod .s drop drop
5 negate .s drop

: nip ( x y -- y )
  { a b } b ;

: tuck ( x y -- y x y )
  { a b } b a b ;

: negate ( x -- -x)
  { a } 0 a - ;

: /mod ( x y -- x%y x/y )
  { a b }
  a b mod
  a b / ;

1 2 nip .s drop
1 2 tuck .s drop drop drop
5 2 /mod .s drop drop
5 negate .s drop
