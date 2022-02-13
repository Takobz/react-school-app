const recordCollections = {
    2548: {
        albumTitle: 'Slippery When Wet',
        artist: 'Bon Jovi',
        tracks: ['123', '456']
    },
    2468: {
        albumTitle: '1999',
        artist: 'Prince',
        tracks: ['1999', 'LRC']
    },
    1245: {
        artist: 'Robert Palmer',
        tracks: []
    },
    2548: {
        albumTitle: 'ABBA Gold',
    }
};

let updateRecords = (records, id, prop, value) => {

    var record = records[id];
    

    if(prop !== 'tracks' && value !== '' && record[prop] !== undefined)
    {
        record[prop] = value;
    }

    if(prop === 'tracks' && record[prop] === undefined)
    {
        //we can also say record.tracks instead of record[prop] where prop = 'tracks'
        let tracks = [];
        record[prop] = tracks.push(value);
    }

    if(prop === 'tracks' && value !== '' && record[prop] !== undefined)
    {
         //we can also say record.tracks instead of record[prop] where prop = 'tracks'
        record.tracks.push(value);
    }

    if(value === '' && record[prop] !== undefined)
    {
        delete record[prop];
    }
}