#!/bin/sh
current_date=$(date --iso-8601=minutes)
git_short_hash=$(git rev-parse --short HEAD)
 
echo $current_date
echo $git_short_hash

sed -i "s/{0}/$current_date/g" wwwroot/index.html
sed -i "s/{1}/$git_short_hash/g" wwwroot/index.html