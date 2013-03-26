1 2 nip .s drop
1 2 tuck .s drop drop drop
5 2 /mod .s drop drop
5 negate .s drop

: nip ( x y -- y )
  swap drop ;

: tuck ( x y -- y x y )
  swap over ;

: negate ( x -- -x)
  0 swap - ;

: /mod ( x y -- x%y x/y )
  2dup / -rot ( x y -- x/y x y )
  2dup / * -  ( x y -- x%y )
  swap ;

1 2 nip .s drop
1 2 tuck .s drop drop drop
5 2 /mod .s drop drop
5 negate .s drop
