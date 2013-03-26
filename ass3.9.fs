1 2 nip .s drop
1 2 tuck .s drop drop drop
5 2 /mod .s drop drop
5 negate .s drop

: nip
  swap drop ;

: tuck
  swap over ;

: negate
  0 swap - ;

: /mod
  2dup / -rot ( x y -- x/y x y )
  2dup / * -  ( x y -- x mod y )
  swap ;

1 2 nip .s drop
1 2 tuck .s drop drop drop
5 2 /mod .s drop drop
5 negate .s drop
