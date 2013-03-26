: quad ( a b c -- s1 s2 )
  { a b c }
  b f@ fdup f* 4e a f@ c f@ f* f* f- ( det = b^2-4ac)
  fdup 0e f< if ( return zeros if det < 0 )
    fdrop 0e 0e exit
  endif
  fsqrt
  fdup b f@ f- 2e a f@ f* f/
  fswap
  fnegate b f@ f- 2e a f@ f* f/
  ;

variable a
variable b
variable c

( 1e a f!
-1e b f!
-6e c f! )
1.23e a f!
4.56e b f!
7.89e c f!

a b c quad f.s
