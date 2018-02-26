db = db.getSiblingDB('admin');
db.createUser({ user: "northernlight", pwd: "minh0c@", roles: [{ role: "userAdminAnyDatabase", db: "admin" }] });
db.createUser({ user: "sa", pwd: "sa", roles: [{ role: "userAdminAnyDatabase", db: "admin" }] });

db = db.getSiblingDB('NL_CLIENTGATE');
print('NL_CLIENTGATE database created');

db.createCollection('clientgate_tokens');
print('NL_CLIENTGATE.clientgate_tokens collections created');
