
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
;;                   EXEMPLE LISP COLOCVIU                  ;;
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;



;scrie raza cercurilor in centru
(defun mirel ( / ) 

    ;(setq m (getstring "Select text: " )) ;bagi textu de la tastatura

    (setq lista (list '(0 . "CIRCLE")) ;selecteaza doar ARCURILE

          ss (ssget "X" lista) ;toate arcurile selectate din desen 
    )

    (setq n 0) ;sryam n 0

    (repeat (sslength ss) ;face loop de ss ori

        (setq 
              arc       (entget (ssname ss n)) ;ia al n-lea arc
              start     (assoc 10 arc) ;start ia paranteza cu 10 adica punctule de inceput al entitatii
              radius    (assoc 40 arc) ;toata liosta cu codul si raza
              x         (car(cdr start)) ;ia al doilea element din lista de startpoint
              y         (caddr start); ia al treilea element al listei 
              r         (cdr radius) ; raza cercului
              valRtext  (rtos r 2 2); valoarea razei convertita in text
              
        )

        (entmake (list '(0 . "TEXT") '(8 . "LAYER0") (list 10 x y 0) '(40 . 1) (cons 1 valRtext) (cons 62 2))) ;1 entity type 2 layer 3 startpoint 4 inaltime text 5 ce text selectezi de la astatura

        (setq n (1+ n)) ;creste n
    )
    (princ) ;nu printeaza de doua ori la final
)

;schimba culoarea la linii
(defun mirel1 ( / )

  (setq culNou (getint "\nculoare: " ))
  (setq 
        lista (list '(0 . "LINE"))
        ss (ssget "X" lista)
  )
  
  (setq n 0)
  
  (repeat (sslength ss)
    
    (setq

      line  (entget (ssname ss n))
      color (assoc 62 line)
      line  (subst (cons 62 culNou) color line)
      
    )
    (entmod line)
    (setq n (1+ n))
  )
  (princ)
        
)

;pune un text custom in centrul arcelor
(defun mirel2 ( / ) 

    (setq m (getstring "Select text: " )) ;bagi textu de la tastatura

    (setq lista (list '(0 . "ARC" )) ;selecteaza doar ARCURILE

          ss (ssget "X" lista) ;toate arcurile selectate din desen 
    )

    (setq n 0) ;sryam n 0

    (repeat (sslength ss) ;face loop de ss ori

        (setq 
              arc   (entget (ssname ss n)) ;ia al n-lea arc
              start (assoc 10 arc) ;start ia paranteza cu 10 adica punctule de inceput al entitatii
              x     (car(cdr start)) ;ia al doilea element din lista de startpoint
              y     (caddr start); ia al treilea element al listei 
        )

        (entmake (list '(0 . "TEXT") '(8 . "LAYER0") (list 10 x y 0) '(40 . 0.5) (cons 1 m))) ;1 entity type 2 layer 3 startpoint 4 inaltime text 5 ce text selectezi de la astatura

        (setq n (1+ n)) ;creste n
    )
    (princ) ;nu printeaza de doua ori la final
)

;schimba raza a mai kmultor cercuri
(defun mirel3 ( / ) 

    (setq m (getint "Select radius: " )) ;bagi textu de la tastatura

    (setq lista (list '(0 . "CIRCLE")) ;selecteaza doar ARCURILE

          ss (ssget "X" lista) ;toate arcurile selectate din desen 
    )

    (setq n 0) ;sryam n 0

    (repeat (sslength ss) ;face loop de ss ori

        (setq 
          
              arc     (entget (ssname ss n)) ;ia al n-lea arc
              radius  (assoc 40 arc) ;toata liosta cu codul si raza
              arc     (subst (cons 40 m) radius arc) 
        )
      
      (entmod arc)
      (setq n (1+ n))
  
    )

    (princ)
)

;face cercurile concentrice intr un puinct selectat de tine dupa coordonate x si y
(defun mirel4 ( x y / )
  
    (setq lista (list '(0 . "CIRCLE")) ;selecteaza doar ARCURILE

          ss (ssget "X" lista) ;toate arcurile selectate din desen 
    )
  
    (setq n 0) ;sryam n 0

    (repeat (sslength ss) ;face loop de ss ori

        (setq 
          
              arc   (entget (ssname ss n)) ;ia al n-lea arc
              start (assoc 10 arc) ;start ia paranteza cu 10 adica punctule de inceput al entitatii
              arc   (subst (list 10 x y 0) start arc)
        )
      
      (entmod arc)
      (setq n (1+ n))
    )
)

;pune lungimea liniei ca text de la mijlocul linii 
  
(defun horica ( / )
  
    (setq lista (list '(0 . "LINE" )) ;selecteaza doar ARCURILE

          ss (ssget "X" lista) ;toate arcurile selectate din desen 
    )
  
(setq n 0)
  
  (repeat (sslength ss)
    
    (setq
          line     (entget (ssname ss n))
          start    (assoc 10 line)
          x1       (car (cdr start))
          y1       (caddr start)
          sfarsit  (assoc 11 line)
          x2       (car (cdr sfarsit))
          y2       (caddr sfarsit)
          xt       ( / ( + x1 x2) 2)
          yt       ( / ( + y1 y2) 2)
          dist     (sqrt (+ (expt (- x1 x2) 2) (expt (- y1 y2))))
          distText (rtos dist)
    )
    
    (entmake (list '(0 . "TEXT") '(8 . "LAYER0") (list 10 xt yt 0) '(40 . 1) (cons 1 distText)))
    
    (setq n (1+ n))
  )
  (princ)

)

;scrie centrul cercului in prompt
(defun centru (/)
  (setq lista (list '(0 . "CIRCLE")) ;filtru pt a gasi cercurile

          ss (ssget "X" lista) ;luam toate entitatile cercuri
    )

    (setq n 0) ;luam n la 0

    (repeat (ss length ss) ;trecem prin tot ss-ul

        (setq 
              circle (entget (ssname ss n)) ;luam al n-lea cerc
              center (cdr(assoc 10 circle)) ;luam coordonatele centrului cercului

        )

        (print center)
      

        (setq n (1+ n)) ;creste n
    )
    (princ) ;nu printeaza de doua ori la final
)

;face raza cerucrilor gen o linie
(defun facRazaCercului ( / ) 


    (setq lista (list '(0 . "CIRCLE")) ;selecteaza doar ARCURILE

          ss (ssget "X" lista) ;toate arcurile selectate din desen 
    )

    (setq n 0)

    (repeat (sslength ss) ;face loop de ss ori

        (setq 
              arc    (entget (ssname ss n)) 
              start  (assoc 10 arc) 
              radius (assoc 40 arc) 
              x      (car(cdr start)) 
              y      (caddr start)
              r      (cdr radius) ; raza cercului
              xf     (+ x r)
        )

        (entmake (list '(0 . "LINE") '(8 . "LAYER0") (list 10 x y 0) (list 11 xf  y  0))) 
      
        (setq n (1+ n)) 
    )
    (princ) 
)

;inytroduci date intr o baza de date
(defun C:PD_ADDENTRY ( / fname lname age entry)

  (initget 1)

  (setq fname (getstring "\nEnter person's first name: "))

  (initget 1)

  (setq lname (getstring "\nEnter person's last name: "))

  (initget 7)

  (setq age (getint "\nEnter person's age: "))

  (setq entry (list (cons 'FN fname) (cons 'LN lname) (cons 'AGE age))

        PD_DATA (append PD_DATA (list entry))

  )

(princ)

 )

;face media varstelor
(defun C:PD_LIST ( / current suma varsta medie ani entry counter)

  (setq current PD_DATA  
        counter 0
        suma 0.0
  ) 

  (while current

    (setq entry  (car current)
          varsta (assoc 'AGE entry)
          ani    (cdr varsta)
          suma   (+ suma ani)
      
    )
    (setq current (cdr current) ; next entry
          counter (1+ counter)
       
    )

  )
  
  (setq medie ( / suma counter))
  (print medie)

  (princ)

)



