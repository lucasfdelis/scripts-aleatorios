def seq_iter(obj):
    if isinstance(obj, list):
        return obj
    else:
        return [obj]

x = [{'a': 2, 'b':3, 'c':4},{'a': 5, 'b':6, 'c':7},{'a': 8, 'b':9, 'c':0}]
for i in seq_iter(x):
    print(i['a'],i['b'],i['c'])

x = {'a': 1, 'b':3, 'c':2}
for i in seq_iter(x):
    print(i['a'],i['b'],i['c'])
