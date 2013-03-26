: type ( addr u -- )
  0 u+do
    dup c@ emit
    char+
  loop ;

create str
  104 c, 101 c, 108 c, 108 c, 111 c,
str 5 type
