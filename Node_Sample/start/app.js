var MongoClient = require('mongodb').MongoClient
, assert = require('assert');

var ObjectID = require('mongodb').ObjectID;

var url = 'mongodb://127.0.0.1:27017/test';

MongoClient.connect(url, function(err, db){

	assert.equal(null,err);

	console.log("Connected correctly to server");

	return db.close();
});