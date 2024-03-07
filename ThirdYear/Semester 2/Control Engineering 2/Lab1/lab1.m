Hf = tf(15, [1 5 0]);
%%
Ts_1 = 0.1;
H_d1_zoh = c2d(Hf, Ts_1, 'zoh');
[n0, d0] = tfdata(H_d1_zoh, 'v');
H_d1_zoh_1 = filt(n0, d0)
H_d1_tustin = c2d(Hf, Ts_1, 'tustin');
[n1, d1] = tfdata(H_d1_tustin, 'v');
H_d1_tustin_1 = filt(n1, d1)
figure
subplot(211)
step(feedback(H_d1_tustin_1, 1))
title("tustin discretization")
subplot(212)
step(feedback(H_d1_zoh_1, 1))
title("zoh discretization")

%%
Ts_2 = 1;
H_d1_zoh = c2d(Hf, Ts_2, 'zoh');
[n0, d0] = tfdata(H_d1_zoh, 'v');
H_d1_zoh_1 = filt(n0, d0)
H_d1_tustin = c2d(Hf, Ts_2, 'tustin');
[n1, d1] = tfdata(H_d1_tustin, 'v');
H_d1_tustin_1 = filt(n1, d1)
figure
subplot(211)
step(feedback(H_d1_tustin_1, 1))
title("tustin discretization")
subplot(212)
step(feedback(H_d1_zoh_1, 1))
title("zoh discretization")
%%
Ts_3 = 2;
H_d1_zoh = c2d(Hf, Ts_3, 'zoh');
[n0, d0] = tfdata(H_d1_zoh, 'v');
H_d1_zoh_1 = filt(n0, d0)
H_d1_tustin = c2d(Hf, Ts_3, 'tustin');
[n1, d1] = tfdata(H_d1_tustin, 'v');
H_d1_tustin_1 = filt(n1, d1)
figure
subplot(211)
step(feedback(H_d1_tustin_1, 1))
title("tustin discretization")
subplot(212)
step(feedback(H_d1_zoh_1, 1))
title("zoh discretization")




