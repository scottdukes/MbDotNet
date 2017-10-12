FROM microsoft/windowsservercore 

EXPOSE 2525
ENTRYPOINT ["mb"]
CMD ["start","--mock"]
ENV MOUNTEBANK_VERSION=1.x

RUN powershell -Command "Set-ExecutionPolicy Bypass; iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))"
RUN choco install -y nodejs
RUN npm install -g mountebank@${MOUNTEBANK_VERSION} --production
