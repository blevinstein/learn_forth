\ nip = swap drop
1 2 nip .s drop
1 2 swap drop .s drop

\ tuck = swap over
1 2 tuck .s drop drop drop
1 2 swap over .s drop drop drop

\ 1 2 3 -- 3 2 1
1 2 3 rot rot swap .s drop drop drop
\ 1 2 3 -- 1 2 3 2
1 2 3 over .s 2drop 2drop
\ 1 2 3 -- 1 2 3 3
1 2 3 dup .s 2drop 2drop
\ 1 2 3 -- 1 3 3
1 2 3 swap drop dup .s drop drop drop
\ 1 2 3 -- 2 1 3
1 2 3 rot swap .s drop drop drop
\ 1 2 3 4 -- 4 3 2 1
1 2 3 4 swap 2swap swap .s 2drop 2drop
\ 1 2 3 -- 1 2 3 1 2 3
1 2 3 2 pick 2 pick 2 pick .s 2drop 2drop 2drop

\ 17^3 and 17^4
17 dup dup * * .
17 dup dup dup * * * .
