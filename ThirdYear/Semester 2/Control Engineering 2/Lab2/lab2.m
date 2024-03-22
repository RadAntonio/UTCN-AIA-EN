%% PI
clear; clc;
hf = tf(2, conv([1 1],[10 1]), 'iodelay', 1);
gammaK = 60;
beta = 0.1;
bode(hf); grid;
hf1 = -180 + gammaK + 15;
wc = 0.297; %pe faza unde am -105 (hf1)
hfMag = -4.33; %pe mag unde am wc
hfMagNumeric = db2mag(hfMag);
kp = 1/hfMagNumeric;
Ti = 4/wc;
Hc = kp + tf(kp, [Ti, 0])
figure
bode(Hc*hf); grid;
title("Hc*Hf")
figure
step(feedback(Hc*hf, 1))

%% PD
hf2 = -180 + gammaK - atand((1 - beta)/(2*sqrt(beta)));
wc2 = 0.865; %pe faza unde am hf2
hfMag2 = -15.3;
hfMag2Numeric = db2mag(hfMag2);
kp = sqrt(beta)/hfMag2Numeric;
taud = 1/(wc2*sqrt(beta));
Hc2 = tf([kp*taud kp], [beta*taud 1])
figure;
bode(Hc2*hf); grid;
title("Hc2*Hf")
figure
step(feedback(Hc2*hf, 1))
%% DISCRETIZARE CONTROLLER PI
Ts = 0.1;
Hdzoh = c2d(Hc, Ts, 'zoh');
figure
step(feedback(Hdzoh, 1))

%% DISCRETIZARE CONTROLLER PD
Hd2zoh = c2d(Hc2, Ts, 'zoh');
figure
step(feedback(Hd2zoh, 1))

%%
[nHcPI, dHcPI] = tfdata(Hc) %PI
[nHcPD, dHcPD] = tfdata(Hc2) %PD
[nHdzoh, dHdzoh] = tfdata(Hdzoh) %PI disccret
[nHd2zoh, dHd2zoh] = tfdata(Hd2zoh) %PD discret

%%
val = filt(nHdzoh, dHdzoh)