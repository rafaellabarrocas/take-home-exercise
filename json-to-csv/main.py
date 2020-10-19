import json
import csv

sample_files = ''

with open(sample_files.json, 'r') as f:
    for line in f.read():
        sample_files += line


sample_files = json.loads(sample_files)

with open('sample_file.csv', 'w') as f:
    writer = csv.DictWriter(f, sample_files[0].keys())
    writer.writeheader()

    for sample_file in sample_files:
        writer.writerow(sample_file)

#print(json.dumps(sample_file, indent=2))