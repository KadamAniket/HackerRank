function getDay(dateString) {
    const day = new Date(dateString);
    return Intl.DateTimeFormat('en-US', { weekday: 'long' }).format(day);
}

console.log(getDay('10/11/2009'));
console.log(getDay('11/10/2010'));