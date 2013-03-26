: fib ( n -- x )
  2 1 1 2swap u+do
    tuck +
  loop
  nip ;

: print_fibs
  10 1 u+do
    i fib .
  loop ;

print_fibs
