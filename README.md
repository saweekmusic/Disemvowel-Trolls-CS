# Disemvowel Trolls

### What we must do?
Trolls are attacking your comment section!

A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.

Your task is to write a function that takes a string and return a new string with all vowels removed.

For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".

Note: for this kata y isn't considered a vowel.

### What we did?
1. Делаем сопоставление через Regex.Replace(string input, string pattern, string replacement) <br/>
input --- String
Строка для поиска соответствия.

pattern --- String
Шаблон регулярного выражения для сопоставления.

replacement --- String
Строка замены.

Ипользуем "(?i)" для игнормрования регистра.

#FUNDAMENTALS #STRINGS #REGULAR_EXPRESSIONS #DECLARATIVE_PROGRAMMING #ADVANCED_LANGUAGE_FEATURES