kf = 4.5;
Tf = 4.5;
Hf = tf(kf, [Tf 1 0]);

tr = 35;
overshoot = 0.15;

xi = abs(log(overshoot))/sqrt((log(overshoot))^2 + pi^2);
wn = 4 / (tr * xi);
cv = wn / (2 * xi);
wb = wn * sqrt(1 - 2*xi^2 + sqrt(2 - 4*xi^2 + 4*xi^4));

Ho2 = tf([wn^2], [1 2*xi*wn wn^2]);
Hr = (1/Hf) * (Ho2/(1 - Ho2));

Hr1 = minreal(Hr);
figure 
step(feedback(Hr1 * Hf, 1))
figure
bode(Hr1*Hf); grid; 
cvbode = db2mag(26.5 - 40)