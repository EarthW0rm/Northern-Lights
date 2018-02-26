FROM alpine:3.7
COPY './mongo_initial_script.js' /data/mongo_initial_script.js

RUN mkdir -p /data/db /data/configdb \
	&& apk add --no-cache mongodb
	
RUN mongod --bind_ip 0.0.0.0 & \
	echo "SLEEPING..........................." \
	&& sleep 10 \
	&& mongo --eval "load('/data/mongo_initial_script.js');" \
	&& mongod --shutdown
EXPOSE 27017
CMD ["mongod", "--bind_ip", "0.0.0.0"]