function sides(literals, ...expressions) {
    const area = expressions[0];
    const perimeter = expressions[1];
    const s1 = (perimeter + Math.sqrt(perimeter * perimeter - 16 * area)) / 4;
    const s2 = (perimeter - Math.sqrt(perimeter * perimeter - 16 * area)) / 4;
    return [s2, s1];
}
