﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Loja.Web.PedidoReferencia {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProdutoViewModel", Namespace="http://schemas.datacontract.org/2004/07/GerenciamentoCompras.Model")]
    [System.SerializableAttribute()]
    public partial class ProdutoViewModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoriaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantidadeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string imagemField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string precoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Categoria {
            get {
                return this.CategoriaField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoriaField, value) != true)) {
                    this.CategoriaField = value;
                    this.RaisePropertyChanged("Categoria");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomeProduto {
            get {
                return this.NomeProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeProdutoField, value) != true)) {
                    this.NomeProdutoField = value;
                    this.RaisePropertyChanged("NomeProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantidade {
            get {
                return this.QuantidadeField;
            }
            set {
                if ((this.QuantidadeField.Equals(value) != true)) {
                    this.QuantidadeField = value;
                    this.RaisePropertyChanged("Quantidade");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idProduto {
            get {
                return this.idProdutoField;
            }
            set {
                if ((this.idProdutoField.Equals(value) != true)) {
                    this.idProdutoField = value;
                    this.RaisePropertyChanged("idProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string imagem {
            get {
                return this.imagemField;
            }
            set {
                if ((object.ReferenceEquals(this.imagemField, value) != true)) {
                    this.imagemField = value;
                    this.RaisePropertyChanged("imagem");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string preco {
            get {
                return this.precoField;
            }
            set {
                if ((object.ReferenceEquals(this.precoField, value) != true)) {
                    this.precoField = value;
                    this.RaisePropertyChanged("preco");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PedidoViewModel", Namespace="http://schemas.datacontract.org/2004/07/GerenciamentoCompras.Model")]
    [System.SerializableAttribute()]
    public partial class PedidoViewModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool PedidoEmpacotadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool PedidoEnviadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Loja.Web.PedidoReferencia.Produto[] ProdutosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idPedidoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool PedidoEmpacotado {
            get {
                return this.PedidoEmpacotadoField;
            }
            set {
                if ((this.PedidoEmpacotadoField.Equals(value) != true)) {
                    this.PedidoEmpacotadoField = value;
                    this.RaisePropertyChanged("PedidoEmpacotado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool PedidoEnviado {
            get {
                return this.PedidoEnviadoField;
            }
            set {
                if ((this.PedidoEnviadoField.Equals(value) != true)) {
                    this.PedidoEnviadoField = value;
                    this.RaisePropertyChanged("PedidoEnviado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Loja.Web.PedidoReferencia.Produto[] Produtos {
            get {
                return this.ProdutosField;
            }
            set {
                if ((object.ReferenceEquals(this.ProdutosField, value) != true)) {
                    this.ProdutosField = value;
                    this.RaisePropertyChanged("Produtos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idPedido {
            get {
                return this.idPedidoField;
            }
            set {
                if ((this.idPedidoField.Equals(value) != true)) {
                    this.idPedidoField = value;
                    this.RaisePropertyChanged("idPedido");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Produto", Namespace="http://schemas.datacontract.org/2004/07/Loja.Domain")]
    [System.SerializableAttribute()]
    public partial class Produto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoriaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImagemField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantidadeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string precoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Categoria {
            get {
                return this.CategoriaField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoriaField, value) != true)) {
                    this.CategoriaField = value;
                    this.RaisePropertyChanged("Categoria");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Imagem {
            get {
                return this.ImagemField;
            }
            set {
                if ((object.ReferenceEquals(this.ImagemField, value) != true)) {
                    this.ImagemField = value;
                    this.RaisePropertyChanged("Imagem");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomeProduto {
            get {
                return this.NomeProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeProdutoField, value) != true)) {
                    this.NomeProdutoField = value;
                    this.RaisePropertyChanged("NomeProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantidade {
            get {
                return this.QuantidadeField;
            }
            set {
                if ((this.QuantidadeField.Equals(value) != true)) {
                    this.QuantidadeField = value;
                    this.RaisePropertyChanged("Quantidade");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idProduto {
            get {
                return this.idProdutoField;
            }
            set {
                if ((this.idProdutoField.Equals(value) != true)) {
                    this.idProdutoField = value;
                    this.RaisePropertyChanged("idProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string preco {
            get {
                return this.precoField;
            }
            set {
                if ((object.ReferenceEquals(this.precoField, value) != true)) {
                    this.precoField = value;
                    this.RaisePropertyChanged("preco");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost:60745/v2", ConfigurationName="PedidoReferencia.PedidoMultiplo")]
    public interface PedidoMultiplo {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:60745/v2/PedidoMultiplo/RealizarPedido", ReplyAction="http://localhost:60745/v2/PedidoMultiplo/RealizarPedidoResponse")]
        string RealizarPedido(Loja.Web.PedidoReferencia.ProdutoViewModel[] ListaProdutos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:60745/v2/PedidoMultiplo/RealizarPedido", ReplyAction="http://localhost:60745/v2/PedidoMultiplo/RealizarPedidoResponse")]
        System.Threading.Tasks.Task<string> RealizarPedidoAsync(Loja.Web.PedidoReferencia.ProdutoViewModel[] ListaProdutos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:60745/v2/PedidoMultiplo/ProximoPedido", ReplyAction="http://localhost:60745/v2/PedidoMultiplo/ProximoPedidoResponse")]
        Loja.Web.PedidoReferencia.PedidoViewModel ProximoPedido();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:60745/v2/PedidoMultiplo/ProximoPedido", ReplyAction="http://localhost:60745/v2/PedidoMultiplo/ProximoPedidoResponse")]
        System.Threading.Tasks.Task<Loja.Web.PedidoReferencia.PedidoViewModel> ProximoPedidoAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PedidoMultiploChannel : Loja.Web.PedidoReferencia.PedidoMultiplo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PedidoMultiploClient : System.ServiceModel.ClientBase<Loja.Web.PedidoReferencia.PedidoMultiplo>, Loja.Web.PedidoReferencia.PedidoMultiplo {
        
        public PedidoMultiploClient() {
        }
        
        public PedidoMultiploClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PedidoMultiploClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PedidoMultiploClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PedidoMultiploClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string RealizarPedido(Loja.Web.PedidoReferencia.ProdutoViewModel[] ListaProdutos) {
            return base.Channel.RealizarPedido(ListaProdutos);
        }
        
        public System.Threading.Tasks.Task<string> RealizarPedidoAsync(Loja.Web.PedidoReferencia.ProdutoViewModel[] ListaProdutos) {
            return base.Channel.RealizarPedidoAsync(ListaProdutos);
        }
        
        public Loja.Web.PedidoReferencia.PedidoViewModel ProximoPedido() {
            return base.Channel.ProximoPedido();
        }
        
        public System.Threading.Tasks.Task<Loja.Web.PedidoReferencia.PedidoViewModel> ProximoPedidoAsync() {
            return base.Channel.ProximoPedidoAsync();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost:60745/v1", ConfigurationName="PedidoReferencia.PedidoUnico")]
    public interface PedidoUnico {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:60745/v1/PedidoUnico/RealizarPedido", ReplyAction="http://localhost:60745/v1/PedidoUnico/RealizarPedidoResponse")]
        string RealizarPedido(Loja.Web.PedidoReferencia.ProdutoViewModel produto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:60745/v1/PedidoUnico/RealizarPedido", ReplyAction="http://localhost:60745/v1/PedidoUnico/RealizarPedidoResponse")]
        System.Threading.Tasks.Task<string> RealizarPedidoAsync(Loja.Web.PedidoReferencia.ProdutoViewModel produto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:60745/v1/PedidoUnico/ProximoPedido", ReplyAction="http://localhost:60745/v1/PedidoUnico/ProximoPedidoResponse")]
        Loja.Web.PedidoReferencia.PedidoViewModel ProximoPedido();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:60745/v1/PedidoUnico/ProximoPedido", ReplyAction="http://localhost:60745/v1/PedidoUnico/ProximoPedidoResponse")]
        System.Threading.Tasks.Task<Loja.Web.PedidoReferencia.PedidoViewModel> ProximoPedidoAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PedidoUnicoChannel : Loja.Web.PedidoReferencia.PedidoUnico, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PedidoUnicoClient : System.ServiceModel.ClientBase<Loja.Web.PedidoReferencia.PedidoUnico>, Loja.Web.PedidoReferencia.PedidoUnico {
        
        public PedidoUnicoClient() {
        }
        
        public PedidoUnicoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PedidoUnicoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PedidoUnicoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PedidoUnicoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string RealizarPedido(Loja.Web.PedidoReferencia.ProdutoViewModel produto) {
            return base.Channel.RealizarPedido(produto);
        }
        
        public System.Threading.Tasks.Task<string> RealizarPedidoAsync(Loja.Web.PedidoReferencia.ProdutoViewModel produto) {
            return base.Channel.RealizarPedidoAsync(produto);
        }
        
        public Loja.Web.PedidoReferencia.PedidoViewModel ProximoPedido() {
            return base.Channel.ProximoPedido();
        }
        
        public System.Threading.Tasks.Task<Loja.Web.PedidoReferencia.PedidoViewModel> ProximoPedidoAsync() {
            return base.Channel.ProximoPedidoAsync();
        }
    }
}