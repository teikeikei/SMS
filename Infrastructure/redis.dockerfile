FROM redis:6.0-alpine as base

# RUN apt-get update && apt-get install -y \
#     vim

COPY redis.conf /config/redis.conf