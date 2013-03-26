: fib ( n -- x )
  { n }
  n 3 < if
    1
  else
    n 1 - recurse
    n 2 - recurse
    +
  endif ;

: print_fibs
  10 1 u+do
    i fib .
  loop ;

print_fibs
