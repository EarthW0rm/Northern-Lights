db = db.getSiblingDB('NL_CLIENTGATE');
print('NL_CLIENTGATE database created');

db.createCollection('clientgate_tokens');
print('NL_CLIENTGATE.clientgate_tokens collections created');
