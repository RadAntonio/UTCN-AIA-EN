%% P 
%pt overshoot
clear; clc;
kf = 4.5;
Tf = 4.5;
Hf = tf(kf, [Tf 1 0]);
figure
bodemag(Hf, 'g'); grid
hold on;    
wf = 1/Tf;
sigma = 0.1;
csi = abs(log(sigma))/sqrt(pi^2+(log(sigma)^2));
A = 1/(4*sqrt(2)*csi^2)
AdB = mag2db(A);

FN = abs(AdB) + 22.9; %magnitudinea in frecventa wf = 22.9
Vr = 10^(-FN/20);

Hd = Hf * Vr;
bodemag(Hd);
legend('Hf', 'Hd')



figure
step(feedback(Hd, 1))

%% PD
%pt settling time
tau_d = Tf;
tr = 31.1;
wt1 = 2/(csi^2*tr);
trstar = 4.5;
TN = tau_d*(trstar/tr);
VrPD = tr/trstar;
H_PD = VrPD * tf([tau_d 1], [TN 1]);
figure
step(feedback(H_PD*Hd,1))
%% PI
%pt cv
cvstar = 3;
cvdB = -17; %valoarea de la 10^-2 pe mag si scadem -40 (hf)
cv = 10^(cvdB/20);

wz = 0.1*cv;
wp = (cv/cvstar) * wz;
Tz = 1/wz;
Tp = 1/wp;

VrPI = cvstar/cv;
H_PI = tf([Tz 1], [Tp 1]);
Hd_PI = VrPI* H_PI*Hd;
Ho_PI = feedback(Hd_PI, 1);
figure
step(Ho_PI);


















