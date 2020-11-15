# CustomControl



## サンプル

### CustomListBox1

`BasedOn` でコントロールスタイルを標準の `ListBox` から継承する。


### CustomListBox2

標準のスタイルを継承せず自力で設定する。 
利用する側のクラスから設定したいプロパティは、全て `TemplateBinding` で個別に渡す必要あり？

Borderは適用されない？
`<Boder>` を親要素として定義する必要がありそう。


### CustomListBox3
`BasedOn` で標準のスタイルを継承しつつ、子要素のスタイルを独自設定する。

## ファイル構成

### デフォルト
カスタムコントロールを追加すると、デフォルトでは `<Project>\Themes\Generic.xaml` に全てのカスタムコントロールのスタイルが定義される。
下記のようなファイル構成になる。

```
<project>
　├ <任意のフォルダ>
　│ 　├ CustomControl1.cs　←カスタムコントロール個別のクラス
　│ 　└ CustomControl2.cs　←　　　〃
　└ Themes/
　　　└ Generic.xaml　　← すべてのカスタムコントロールのスタイルを記述
```

### 推奨構成
デフォルトの構成は`Generic.xaml` が肥大化し、管理がしづらくなる。
`ResourceDictionary.MergedDictionaries` を使用し、以下の構成に変更することを推奨。

```
<project>
　├ <任意のフォルダ>
　│ 　├ CustomControl1.cs　　←カスタムコントロール1のクラス
　│ 　└ CustomControl1.xaml　←カスタムコントロール1のスタイル
　├ <任意のフォルダ>
　│ 　├ CustomControl2.cs　　←カスタムコントロール2のクラス
　│ 　└ CustomControl2.xaml　←カスタムコントロール2のスタイル
　└ Themes/
　　　└ Generic.xaml　　← `ResourceDictionary` で個別のxamlを参照する
```


### 注意点

`<Project>\Themes\Generic.xaml` のパスは変更不可。

