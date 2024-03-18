(defun circle_n ( / ) 

    (setq radius (getint "Select radius: " )) ;introduc raza de la tastatura

    (setq lista (list '(0 . "POINT")) 

          ss (ssget "X" lista) 
    )

    (setq n 0) 

    (repeat (sslength ss) 

        (setq 
              punct     (entget (ssname ss n)) ;iau cate un punct pe rand
              start     (assoc 10 punct) 
              x         (car(cdr start)) ;aflu x punct
              y         (caddr start) ;aflu y punct
              
        )

        (entmake (list '(0 . "CIRCLE") '(8 . "LAYER0") (list 10 x y 0) (cons 40 radius))) ;creez entitatea cerc cu centrul in coordonatele punctu;ui si raza de la tastatua

        (setq n (1+ n)) ; cresc n
    )
    (princ) 
)