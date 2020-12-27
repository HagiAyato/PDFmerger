<h1>PDFmerger</h1>
PDFファイルの結合アプリケーションです。
<h2>インストール方法</h2>
TODO
<h2>使い方</h2>
<ol type="1">
   <li>アプリケーション"PDFmerger.exe"を開く</li>
   <li>PDFファイルの結合構成を行う
     <ul>
       <li>"+追加"ボタン…結合するPDFを、結合PDFリストの一番下に追加する(複数選択可能)</li>
       <li>"▲一番上へ"ボタン…選択中のPDFを、結合PDFリストの一番上に移動する</li>
       <li>"△一行上へ"ボタン…選択中のPDFを、結合PDFリストの一行上に移動する<br/>
         ※選択中のPDFのうち、一番上のPDFを基準にします。
       </li>
       <li>"△一行下へ"ボタン…選択中のPDFを、結合PDFリストの一行下に移動する<br/>
         ※選択中のPDFのうち、一番下のPDFを基準にします。
       </li>
       <li>"▼一番下へ"ボタン…選択中のPDFを、結合PDFリストの一番下に移動する
       </li>
       <li>"-削除"ボタン…選択中のPDFを、結合PDFリストから削除する</li>
     </ul>
   </li>
   <li>出力ファイル名・パスを決定する(下記いずれかの方法)<br/>
     1.出力ファイルパス欄に、直接入力<br/>
     &nbsp;※パスを入力しない場合は、アプリケーション"PDFmerger.exe"と同じフォルダに出力されます。<br/>
     2."出力ファイル変更"ボタンを押して、ダイアログで名前を決定する<br/>
     3."結合・出力"ボタンを押した際に決定する(この段階では出力ファイルパス欄を空欄にする)
   </li>
   <li>"結合・出力"ボタンを押して、結合したPDFを出力する</li>
</ol>
<h3>拡張機能</h3>
<h4><b>◆結合設定書き出し/読み込み機能◆</b></h4>
<p>
  現在の結合PDFリストと出力ファイルパスの設定をファイルに書き出し/読み込みする機能です。<br/>
  上部メニュー"ファイル"から起動します。<br/>
  拡張子…".dat"<br/>
  <ul>
    <li>ファイル&gt;結合設定&gt;結合設定読み込み…既に存在する結合設定ファイルを読み込む<br/>
    &nbsp;※アプリケーションに現状入力されている設定は破棄されます。
    </li>
    <li>ファイル&gt;結合設定&gt;結合設定読み込み…結合設定ファイルを作成・名前を付けて保存する</li>
  </ul>
</p>
<h4>PDFファイルドロップ機能</h4>
<p>
   アプリケーションにPDFファイルをドラッグアンドドロップすると、<br/>
   ドラッグアンドドロップしたPDFファイル全てを結合PDFリストの一番下に追加します。
</p>
<h2>補足情報</h2>
<h4>使用ライブラリ</h4>
・PDFsharp version="1.50.5147"
<h4>ライセンス表記(MITライセンス)</h4>
Creator of PDFsharp is empira Software GmbH<br/>
Kirchstrase 19 53840 Troisdorf Germany<br/>
www.empira.de<br/>
PDFsharp (R) is a registered trademark of empira Software GmbH<br/>
Released under the MIT license<br/>
http://www.pdfsharp.net/PDFsharp_License.ashx?AspxAutoDetectCookieSupport=1
