/*accum("abcd") -> "A-Bb-Ccc-Dddd"
accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
accum("cwAt") -> "C-Ww-Aaa-Tttt"
The parameter of accum is a string which includes only letters from a..z and A..Z.
expecting
A-Bb-Ccc-Dddd
*/

function accum(s) {
            // your code
            // for loop until i reach length of s
            // mumblestring is s[i].toUpper  + s[i].repeat(i) + '-'
            var mumblestring = ''
            for (i = 0; i < s.length; i++) {
                mumblestring = mumblestring + s.charAt(i).toUpperCase()
                mumblestring = mumblestring + s.charAt(i).toLowerCase().repeat(i)
                mumblestring = mumblestring + '-'
            }
            mumblestring = mumblestring.substring(0, mumblestring.length - 1)
            console.log(mumblestring)
            return mumblestring
        }