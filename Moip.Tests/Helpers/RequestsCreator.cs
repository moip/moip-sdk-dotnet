﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moip.Tests.Helpers
{
    class RequestsCreator
    {
        public static Moip.Models.OrderRequest createOrderRequest()
        {
            Moip.Models.TaxDocument taxDocument = new Moip.Models.TaxDocument
            {
                Type = "CPF",
                Number = "22222222222"
            };

            Moip.Models.Phone phone = new Moip.Models.Phone
            {
                CountryCode = "55",
                AreaCode = "11",
                Number = "66778899"
            };

            Moip.Models.ShippingAddress shippingAddress = new Moip.Models.ShippingAddress
            {
                Street = "Rua test",
                StreetNumber = "123",
                Complement = "Ap test",
                District = "Bairro test",
                City = "TestCity",
                State = "SP",
                Country = "BRA",
                ZipCode = "01234000"
            };

            Moip.Models.CustomerRequest customerRequest = new Moip.Models.CustomerRequest
            {
                Fullname = "Fulano de Tal",
                OwnId = "OFulanoDeTal",
                BirthDate = "1990-01-01",
                Email = "fulano@detal.com.br",
                Phone = phone,
                ShippingAddress = shippingAddress,
                TaxDocument = taxDocument
            };

            Moip.Models.SubtotalsRequest subtotalsRequest = new Moip.Models.SubtotalsRequest
            {
                Shipping = 1500,
                Addition = 20,
                Discount = 10
            };


            Moip.Models.AmountOrderRequest amountRequest = new Moip.Models.AmountOrderRequest
            {
                Currency = "BRL",
                Subtotals = subtotalsRequest
            };

            Moip.Models.Item itemsRequest = new Moip.Models.Item
            {
                Product = "Bicicleta Specialized Tarmac 26 Shimano Alivio",
                Quantity = 1,
                Detail = "uma linda bicicleta",
                Price = 2000
            };

            List<Moip.Models.Item> itemsRequestList = new List<Moip.Models.Item>
            {
                itemsRequest
            };

            Moip.Models.OrderRequest orderRequest = new Moip.Models.OrderRequest
            {
                OwnId = "my_own_id",
                Amount = amountRequest,
                Items = itemsRequestList,
                Customer = customerRequest,
            };

            return orderRequest;
        }

        public static Moip.Models.OrderRequest createOrderWithReceiversRequest()
        {
            Moip.Models.TaxDocument taxDocument = new Moip.Models.TaxDocument
            {
                Type = "CPF",
                Number = "22222222222"
            };

            Moip.Models.Phone phone = new Moip.Models.Phone
            {
                CountryCode = "55",
                AreaCode = "11",
                Number = "66778899"
            };

            Moip.Models.ShippingAddress shippingAddress = new Moip.Models.ShippingAddress
            {
                Street = "Rua test",
                StreetNumber = "123",
                Complement = "Ap test",
                District = "Bairro test",
                City = "TestCity",
                State = "SP",
                Country = "BRA",
                ZipCode = "01234000"
            };

            Moip.Models.CustomerRequest customerRequest = new Moip.Models.CustomerRequest
            {
                Fullname = "Fulano de Tal",
                OwnId = "OFulanoDeTal",
                BirthDate = "1990-01-01",
                Email = "fulano@detal.com.br",
                Phone = phone,
                ShippingAddress = shippingAddress,
                TaxDocument = taxDocument
            };


            Moip.Models.SubtotalsRequest subtotalsRequest = new Moip.Models.SubtotalsRequest
            {
                Shipping = 1500,
                Addition = 20,
                Discount = 10
            };

            Moip.Models.AmountOrderRequest amountRequest = new Moip.Models.AmountOrderRequest
            {
                Currency = "BRL",
                Subtotals = subtotalsRequest
            };

            Moip.Models.Item itemsRequest = new Moip.Models.Item
            {
                Product = "Bicicleta Specialized Tarmac 26 Shimano Alivio",
                Quantity = 1,
                Detail = "uma linda bicicleta",
                Price = 2000
            };

            List<Moip.Models.Item> itemsRequestList = new List<Moip.Models.Item>
            {
                itemsRequest
            };

            Moip.Models.MoipAccountReceiverRequest moipAccountReceiver1 = new Moip.Models.MoipAccountReceiverRequest
            {
                Id = "MPA-14AC21F09CAE"
            };

            Moip.Models.AmountReceiverRequest amountReceiver1 = new Moip.Models.AmountReceiverRequest
            {
                Percentual = 50
            };

            Moip.Models.ReceiverRequest receiver1 = new Moip.Models.ReceiverRequest
            {
                MoipAccount = moipAccountReceiver1,
                Type = "SECONDARY",
                Amount = amountReceiver1
            };

            Moip.Models.MoipAccountReceiverRequest moipAccountReceiver2 = new Moip.Models.MoipAccountReceiverRequest
            {
                Id = "MPA-B0D880F21EF1"
            };

            Moip.Models.AmountReceiverRequest amountReceiver2 = new Moip.Models.AmountReceiverRequest
            {
                Percentual = 50
            };

            Moip.Models.ReceiverRequest receiver2 = new Moip.Models.ReceiverRequest
            {
                MoipAccount = moipAccountReceiver2,
                Type = "SECONDARY",
                Amount = amountReceiver2
            };

            List<Moip.Models.ReceiverRequest> receiverList = new List<Moip.Models.ReceiverRequest>
            {
                receiver1,
                receiver2
            };

            Moip.Models.OrderRequest orderRequest = new Moip.Models.OrderRequest
            {
                OwnId = "my_own_id",
                Amount = amountRequest,
                Items = itemsRequestList,
                Customer = customerRequest,
                Receivers = receiverList
            };

            return orderRequest;
        }

        public static Moip.Models.PaymentRequest CreatePaymentWithCCRequest()
        {

            Moip.Models.TaxDocument taxDocumentRequest = new Moip.Models.TaxDocument
            {
                Type = "CPF",
                Number = "33333333333"
            };

            Moip.Models.Phone phoneRequest = new Moip.Models.Phone
            {
                CountryCode = "55",
                AreaCode = "11",
                Number = "66778899"
            };

            Moip.Models.HolderRequest holderRequest = new Moip.Models.HolderRequest
            {
                Fullname = "Jose Goku da Silva",
                Birthdate = "1988-12-30",
                TaxDocument = taxDocumentRequest,
                Phone = phoneRequest
            };

            Moip.Models.CreditCardRequest creditCardRequest = new Moip.Models.CreditCardRequest
            {
                ExpirationMonth = "02",
                ExpirationYear = "20",
                Number = "5555666677778884",
                Cvc = "123",
                Holder = holderRequest
            };

            Moip.Models.FundingInstrumentRequest fundingInstrumentRequest = new Moip.Models.FundingInstrumentRequest
            {
                Method = "CREDIT_CARD",
                CreditCard = creditCardRequest
            };

            Moip.Models.PaymentRequest paymentRequest = new Moip.Models.PaymentRequest
            {
                InstallmentCount = 1,
                StatementDescriptor = "MyStore",
                FundingInstrument = fundingInstrumentRequest
            };

            return paymentRequest;

        }

        public static Moip.Models.PaymentRequest CreatePaymentWithPreAuthorizationRequest()
        {

            Moip.Models.TaxDocument taxDocumentRequest = new Moip.Models.TaxDocument
            {
                Type = "CPF",
                Number = "33333333333"
            };

            Moip.Models.Phone phoneRequest = new Moip.Models.Phone
            {
                CountryCode = "55",
                AreaCode = "11",
                Number = "66778899"
            };

            Moip.Models.HolderRequest holderRequest = new Moip.Models.HolderRequest
            {
                Fullname = "Jose Goku da Silva",
                Birthdate = "1988-12-30",
                TaxDocument = taxDocumentRequest,
                Phone = phoneRequest
            };

            Moip.Models.CreditCardRequest creditCardRequest = new Moip.Models.CreditCardRequest
            {
                ExpirationMonth = "02",
                ExpirationYear = "20",
                Number = "5555666677778884",
                Cvc = "123",
                Holder = holderRequest
            };

            Moip.Models.FundingInstrumentRequest fundingInstrumentRequest = new Moip.Models.FundingInstrumentRequest
            {
                Method = "CREDIT_CARD",
                CreditCard = creditCardRequest
            };

            Moip.Models.PaymentRequest paymentRequest = new Moip.Models.PaymentRequest
            {
                InstallmentCount = 1,
                StatementDescriptor = "MyStore",
                FundingInstrument = fundingInstrumentRequest,
                DelayCapture = true
            };

            return paymentRequest;

        }

        public static Moip.Models.PaymentBoletoOrDebitRequest CreatePaymentWithBoletoRequest()
        {

            Moip.Models.BoletoInstructionLines boletoInstructionLines = new Moip.Models.BoletoInstructionLines()
            {
                First = "TESTETETSTTTST",
                Second = "tfcsddlksjsd",
                Third = "lkshglashiuahgha"
            };

            Moip.Models.BoletoRequest boletoRequest = new Moip.Models.BoletoRequest()
            {
                ExpirationDate = "2020-09-30",
                InstructionLines = boletoInstructionLines,
                LogoUri = "http://"
            };

            Moip.Models.FundingInstrumentRequest fundingInstrumentRequest = new Moip.Models.FundingInstrumentRequest
            {
                Method = "BOLETO",
                Boleto = boletoRequest
            };

            Moip.Models.PaymentBoletoOrDebitRequest paymentRequest = new Moip.Models.PaymentBoletoOrDebitRequest
            {
                FundingInstrument = fundingInstrumentRequest
            };

            return paymentRequest;

        }

        public static Moip.Models.PaymentBoletoOrDebitRequest CreatePaymentWithOnlineDebitRequest()
        {
            Moip.Models.OnlineBankDebitRequest onlineBankDebitRequest = new Moip.Models.OnlineBankDebitRequest()
            {
                BankNumber = 341,
                ExpirationDate = "2020-09-30"
            };

            Moip.Models.FundingInstrumentRequest fundingInstrumentRequest = new Moip.Models.FundingInstrumentRequest
            {
                Method = "ONLINE_BANK_DEBIT",
                OnlineBankDebit = onlineBankDebitRequest
            };

            Moip.Models.PaymentBoletoOrDebitRequest paymentRequest = new Moip.Models.PaymentBoletoOrDebitRequest
            {
                FundingInstrument = fundingInstrumentRequest
            };

            return paymentRequest;

        }

        public static Moip.Models.NotificationPreferenceRequest CreateNotificationRequest()
        {
            List<string> eventsList = new List<string>();
            eventsList.Add("ORDER.*");
            eventsList.Add("PAYMENT.AUTHORIZED");
            eventsList.Add("PAYMENT.CANCELLED");

            Moip.Models.NotificationPreferenceRequest notificationPreferenceRequest = new Moip.Models.NotificationPreferenceRequest()
            {
                Events = eventsList,
                Target = "http://requestb.in/1dhjesw1",
                Media = "WEBHOOK"
            };
            return notificationPreferenceRequest;

        }

        public static Moip.Models.PaymentRequest CreatePaymentWithEscrowRequest()
        {

            Moip.Models.TaxDocument taxDocumentRequest = new Moip.Models.TaxDocument
            {
                Type = "CPF",
                Number = "33333333333"
            };

            Moip.Models.Phone phoneRequest = new Moip.Models.Phone
            {
                CountryCode = "55",
                AreaCode = "11",
                Number = "66778899"
            };

            Moip.Models.HolderRequest holderRequest = new Moip.Models.HolderRequest
            {
                Fullname = "Jose Goku da Silva",
                Birthdate = "1988-12-30",
                TaxDocument = taxDocumentRequest,
                Phone = phoneRequest
            };

            Moip.Models.CreditCardRequest creditCardRequest = new Moip.Models.CreditCardRequest
            {
                ExpirationMonth = "02",
                ExpirationYear = "20",
                Number = "5555666677778884",
                Cvc = "123",
                Holder = holderRequest
            };

            Moip.Models.FundingInstrumentRequest fundingInstrumentRequest = new Moip.Models.FundingInstrumentRequest
            {
                Method = "CREDIT_CARD",
                CreditCard = creditCardRequest
            };

            Moip.Models.Escrow escrow = new Moip.Models.Escrow
            {
                Description = "Escrow test"
            };

            Moip.Models.PaymentRequest paymentRequest = new Moip.Models.PaymentRequest
            {
                InstallmentCount = 1,
                StatementDescriptor = "MyStore",
                FundingInstrument = fundingInstrumentRequest,
                Escrow = escrow
            };

            return paymentRequest;

        }

        public static Moip.Models.RefundCCRequest CreateFullCCRefundRequest()
        {
            Moip.Models.Phone phoneRequest = new Moip.Models.Phone
            {
                CountryCode = "55",
                AreaCode = "11",
                Number = "66778899"
            };

            Moip.Models.TaxDocument taxDocumentRequest = new Moip.Models.TaxDocument
            {
                Type = "CPF",
                Number = "33333333333"
            };

            Moip.Models.HolderRequest holderRequest = new Moip.Models.HolderRequest
            {
                Fullname = "Jose Goku da Silva",
                Birthdate = "1988-12-30",
                TaxDocument = taxDocumentRequest,
                Phone = phoneRequest,

            };

            Moip.Models.CreditCardRequest creditCardRequest = new Moip.Models.CreditCardRequest
            {
                Number = "5555666677778884",
                ExpirationMonth = "02",
                ExpirationYear = "20",
                Cvc = "123",
                Holder = holderRequest
            };

            Moip.Models.RefundingInstrumentCCRequest refundingInstrumentRequest = new Moip.Models.RefundingInstrumentCCRequest
            {
                Method = "CREDIT_CARD",
                CreditCard = creditCardRequest
            };

            Moip.Models.RefundCCRequest refundRequest = new Moip.Models.RefundCCRequest
            {
                RefundingInstrument = refundingInstrumentRequest,
            };

            return refundRequest;

        }

        public static Moip.Models.RefundCCRequest CreatePartialCCRefundRequest()
        {
            Moip.Models.Phone phoneRequest = new Moip.Models.Phone
            {
                CountryCode = "55",
                AreaCode = "11",
                Number = "66778899"
            };

            Moip.Models.TaxDocument taxDocumentRequest = new Moip.Models.TaxDocument
            {
                Type = "CPF",
                Number = "33333333333"
            };

            Moip.Models.HolderRequest holderRequest = new Moip.Models.HolderRequest
            {
                Fullname = "Jose Goku da Silva",
                Birthdate = "1988-12-30",
                TaxDocument = taxDocumentRequest,
                Phone = phoneRequest,

            };

            Moip.Models.CreditCardRequest creditCardRequest = new Moip.Models.CreditCardRequest
            {
                Number = "5555666677778884",
                ExpirationMonth = "02",
                ExpirationYear = "20",
                Cvc = "123",
                Holder = holderRequest
            };

            Moip.Models.RefundingInstrumentCCRequest refundingInstrumentRequest = new Moip.Models.RefundingInstrumentCCRequest
            {
                Method = "CREDIT_CARD",
                CreditCard = creditCardRequest
            };

            Moip.Models.RefundCCRequest refundRequest = new Moip.Models.RefundCCRequest
            {
                RefundingInstrument = refundingInstrumentRequest,
                Amount = 100
            };

            return refundRequest;

        }

        public static Moip.Models.RefundBankAccountRequest CreateFullBankAccountRefundRequest()
        {
            Moip.Models.TaxDocument taxDocumentRequest = new Moip.Models.TaxDocument
            {
                Type = "CPF",
                Number = "22222222222"
            };

            Moip.Models.HolderRequest holderRequest = new Moip.Models.HolderRequest
            {
                Fullname = "Fulano de Tal",
                Birthdate = "1990-01-01",
                TaxDocument = taxDocumentRequest,

            };

            Moip.Models.BankAccountRefundingInstrumentRequest bankAccountRefundRequest = new Moip.Models.BankAccountRefundingInstrumentRequest
            {
                BankNumber = "341",
                AgencyNumber = "4444444",
                AgencyCheckNumber = "2",
                AccountNumber = "1234",
                AccountCheckNumber = "1",
                Type = "CHECKING",
                Holder = holderRequest
            };

            Moip.Models.RefundingInstrumentBankAccountRequest refundingInstrumentRequest = new Moip.Models.RefundingInstrumentBankAccountRequest
            {
                Method = "BANK_ACCOUNT",
                BankAccount = bankAccountRefundRequest
            };

            Moip.Models.RefundBankAccountRequest refundRequest = new Moip.Models.RefundBankAccountRequest
            {
                RefundingInstrument = refundingInstrumentRequest,
            };

            return refundRequest;

        }

        public static Moip.Models.RefundBankAccountRequest CreatePartialBankAccountRefundRequest()
        {

            Moip.Models.TaxDocument taxDocumentRequest = new Moip.Models.TaxDocument
            {
                Type = "CPF",
                Number = "22222222222"
            };

            Moip.Models.HolderRequest holderRequest = new Moip.Models.HolderRequest
            {
                Fullname = "Fulano de Tal",
                Birthdate = "1990-01-01",
                TaxDocument = taxDocumentRequest,

            };

            Moip.Models.BankAccountRefundingInstrumentRequest bankAccountRefundRequest = new Moip.Models.BankAccountRefundingInstrumentRequest
            {
                BankNumber = "341",
                AgencyNumber = "4444444",
                AgencyCheckNumber = "2",
                AccountNumber = "1234",
                AccountCheckNumber = "1",
                Type = "CHECKING",
                Holder = holderRequest
            };

            Moip.Models.RefundingInstrumentBankAccountRequest refundingInstrumentRequest = new Moip.Models.RefundingInstrumentBankAccountRequest
            {
                Method = "BANK_ACCOUNT",
                BankAccount = bankAccountRefundRequest
            };

            Moip.Models.RefundBankAccountRequest refundRequest = new Moip.Models.RefundBankAccountRequest
            {
                RefundingInstrument = refundingInstrumentRequest,
                Amount = 100
            };

            return refundRequest;

        }

        public static Moip.Models.CustomerRequest CreateCustomerRequest(string date)
        {
            Moip.Models.ShippingAddress shippingAddressRequest = new Moip.Models.ShippingAddress
            {
                Street = "Rua test",
                StreetNumber = "123",
                Complement = "Ap test",
                District = "Bairro test",
                City = "TestCity",
                State = "SP",
                Country = "BRA",
                ZipCode = "01234000"
            };

            Moip.Models.TaxDocument taxDocumentRequest = new Moip.Models.TaxDocument
            {
                Type = "CPF",
                Number = "33333333333"
            };

            Moip.Models.Phone phoneRequest = new Moip.Models.Phone
            {
                CountryCode = "55",
                AreaCode = "11",
                Number = "66778899"
            };

            Moip.Models.CustomerRequest customerRequest = new Moip.Models.CustomerRequest
            {
                Fullname = "Fulano de Tal",
                OwnId = "OFulanoDeTal" + date,
                BirthDate = "1990-01-01",
                Email = "fulano@detal.com.br",
                Phone = phoneRequest,
                ShippingAddress = shippingAddressRequest,
                TaxDocument = taxDocumentRequest
            };

            return customerRequest;
        }

        public static Moip.Models.CustomerRequest CreateCustomerWithFundingInstrumentRequest(string date)
        {
            Moip.Models.ShippingAddress shippingAddressRequest = new Moip.Models.ShippingAddress
            {
                Street = "Rua test",
                StreetNumber = "123",
                Complement = "Ap test",
                District = "Bairro test",
                City = "TestCity",
                State = "SP",
                Country = "BRA",
                ZipCode = "01234000"
            };

            Moip.Models.TaxDocument taxDocumentRequest = new Moip.Models.TaxDocument
            {
                Type = "CPF",
                Number = "33333333333"
            };

            Moip.Models.Phone phoneRequest = new Moip.Models.Phone
            {
                CountryCode = "55",
                AreaCode = "11",
                Number = "66778899"
            };

            Moip.Models.HolderRequest holderRequest = new Moip.Models.HolderRequest
            {
                Fullname = "Jose Goku da Silva",
                Birthdate = "1988-12-30",
                TaxDocument = taxDocumentRequest,
                Phone = phoneRequest
            };

            Moip.Models.CreditCardRequest creditCardRequest = new Moip.Models.CreditCardRequest
            {
                ExpirationMonth = "02",
                ExpirationYear = "20",
                Number = "5555666677778884",
                Cvc = "123",
                Holder = holderRequest
            };

            Moip.Models.FundingInstrumentRequest fundingInstrumentRequest = new Moip.Models.FundingInstrumentRequest
            {
                Method = "CREDIT_CARD",
                CreditCard = creditCardRequest
            };

            Moip.Models.CustomerRequest customerRequest = new Moip.Models.CustomerRequest
            {
                Fullname = "Fulano de Tal",
                OwnId = "OFulanoDeTal" + date,
                BirthDate = "1990-01-01",
                Email = "fulano@detal.com.br",
                Phone = phoneRequest,
                ShippingAddress = shippingAddressRequest,
                TaxDocument = taxDocumentRequest,
                FundingInstrument = fundingInstrumentRequest
            };

            return customerRequest;
        }

        public static Moip.Models.CustomerCreditCardRequest CreateCustomerCreditCardRequest()
        {
            Moip.Models.ShippingAddress shippingAddressRequest = new Moip.Models.ShippingAddress
            {
                Street = "Rua test",
                StreetNumber = "123",
                Complement = "Ap test",
                District = "Bairro test",
                City = "TestCity",
                State = "SP",
                Country = "BRA",
                ZipCode = "01234000"
            };

            Moip.Models.TaxDocument taxDocumentRequest = new Moip.Models.TaxDocument
            {
                Type = "CPF",
                Number = "33333333333"
            };

            Moip.Models.Phone phoneRequest = new Moip.Models.Phone
            {
                CountryCode = "55",
                AreaCode = "11",
                Number = "66778899"
            };

            Moip.Models.HolderRequest holderRequest = new Moip.Models.HolderRequest
            {
                Fullname = "Jose Goku da Silva",
                Birthdate = "1988-12-30",
                TaxDocument = taxDocumentRequest,
                Phone = phoneRequest
            };

            Moip.Models.CreditCardRequest creditCardRequest = new Moip.Models.CreditCardRequest
            {
                ExpirationMonth = "02",
                ExpirationYear = "20",
                Number = "5555666677778884",
                Cvc = "123",
                Holder = holderRequest
            };

            Moip.Models.CustomerCreditCardRequest customerCreditCardRequest = new Moip.Models.CustomerCreditCardRequest
            {
                Method = "CREDIT_CARD",
                CreditCard = creditCardRequest
            };

            return customerCreditCardRequest;
        }


        public static Moip.Models.AccountRequest CreateAccountPersonRequest()
        {

            Moip.Models.EmailRequest emailRequest = new Models.EmailRequest
            {
                Address = "testingarandomemail10@labs.moip.com.br"
            };

            Moip.Models.TaxDocument taxDocumentRequest = new Models.TaxDocument
            {
                Type = "CPF",
                Number = "736.141.550-48"
            };

            Moip.Models.IdentityDocumentRequest identityDocumentRequest = new Models.IdentityDocumentRequest
            {
                Type = "RG",
                Number = "434322344",
                Issuer = "SSP",
                IssueDate = "2000-12-12"
            };

            Moip.Models.Phone phoneRequest = new Models.Phone
            {
                CountryCode = "55",
                AreaCode = "11",
                Number = "712341234"
            };

            Moip.Models.ShippingAddress shippingAddressRequest = new Models.ShippingAddress
            {
                Street = "Av. Brigadeiro Faria Lima",
                StreetNumber = "2927",
                District = "Itaim",
                ZipCode = "01234-000",
                City = "São Paulo",
                State = "SP",
                Country = "BRA"
            };

            Moip.Models.Person personRequest = new Models.Person
            {
                Name = "Runscope",
                LastName = "Goku",
                TaxDocument = taxDocumentRequest,
                IdentityDocument = identityDocumentRequest,
                BirthDate = "1990-01-01",
                Phone = phoneRequest,
                Address = shippingAddressRequest,
            };

            Moip.Models.AccountRequest accountRequest = new Moip.Models.AccountRequest
            {
                Email = emailRequest,
                Person = personRequest,
                Type = "MERCHANT"
            };

            return accountRequest;
        }

        public static Moip.Models.AccountRequest CreateAccountCompanyRequest()
        {
            Moip.Models.EmailRequest emailRequest = new Models.EmailRequest
            {
                Address = "dev.moip@labs.moip.com.br"
            };

            Moip.Models.TaxDocument personTaxDocumentRequest = new Models.TaxDocument
            {
                Type = "CPF",
                Number = "123.456.798-91"
            };

            Moip.Models.IdentityDocumentRequest identityDocumentRequest = new Models.IdentityDocumentRequest
            {
                Type = "RG",
                Number = "434322344",
                Issuer = "SSP",
                IssueDate = "2000-12-12"
            };

            Moip.Models.Phone personPhoneRequest = new Models.Phone
            {
                CountryCode = "55",
                AreaCode = "11",
                Number = "712341234"
            };

            Moip.Models.ShippingAddress shippingAddressRequest = new Models.ShippingAddress
            {
                Street = "Av. Brigadeiro Faria Lima",
                StreetNumber = "2927",
                District = "Itaim",
                ZipCode = "01234-000",
                City = "São Paulo",
                State = "SP",
                Country = "BRA"
            };

            Moip.Models.Person personRequest = new Models.Person
            {
                Name = "Runscope",
                LastName = "Goku",
                TaxDocument = personTaxDocumentRequest,
                IdentityDocument = identityDocumentRequest,
                BirthDate = "1990-01-01",
                Phone = personPhoneRequest,
                Address = shippingAddressRequest,
            };

            Moip.Models.TaxDocument companyTaxDocumentRequest = new Models.TaxDocument
            {
                Type = "CNPJ",
                Number = "11.698.147/0001-13"
            };

            Moip.Models.MainActivityRequest mainActivityRequest = new Models.MainActivityRequest
            {
                Cnae = "82.91-1/00",
                Description = "Atividades de cobranças e informações cadastrais"
            };

            Moip.Models.Phone companyPhoneRequest = new Models.Phone
            {
                CountryCode = "55",
                AreaCode = "11",
                Number = "32234455"
            };

            Moip.Models.ShippingAddress companyAddressRequest = new Models.ShippingAddress
            {
                Street = "Av. Brigadeiro Faria Lima",
                StreetNumber = "2927",
                District = "Itaim",
                ZipCode = "01234-000",
                City = "São Paulo",
                State = "SP",
                Country = "BRA"
            };

            Moip.Models.CompanyRequest companyRequest = new Models.CompanyRequest
            {
                Name = "Empresa Moip",
                BusinessName = "Moip Pagamentos",
                OpeningDate = "2011-01-01",
                TaxDocument = companyTaxDocumentRequest,
                MainActivity = mainActivityRequest,
                Phone = companyPhoneRequest,
                Address = companyAddressRequest

            };

            Moip.Models.BusinessSegmentRequest businessSegmentRequest = new Moip.Models.BusinessSegmentRequest
            {
                Id = 3
            };

            Moip.Models.AccountRequest accountRequest = new Moip.Models.AccountRequest
            {
                Email = emailRequest,
                Person = personRequest,
                Company = companyRequest,
                BusinessSegment = businessSegmentRequest,
                Type = "MERCHANT"
            };

            return accountRequest;
        }

        public static Moip.Models.AccountRequest CreateAccountTransparentRequest()
        {

            Moip.Models.EmailRequest emailRequest = new Models.EmailRequest
            {
                Address = "testingarandomemail10@labs.moip.com.br"
            };

            Moip.Models.TaxDocument taxDocumentRequest = new Models.TaxDocument
            {
                Type = "CPF",
                Number = "736.141.550-48"
            };

            Moip.Models.IdentityDocumentRequest identityDocumentRequest = new Models.IdentityDocumentRequest
            {
                Type = "RG",
                Number = "434322344",
                Issuer = "SSP",
                IssueDate = "2000-12-12"
            };

            Moip.Models.Phone phoneRequest = new Models.Phone
            {
                CountryCode = "55",
                AreaCode = "11",
                Number = "712341234"
            };

            Moip.Models.ShippingAddress shippingAddressRequest = new Models.ShippingAddress
            {
                Street = "Av. Brigadeiro Faria Lima",
                StreetNumber = "2927",
                District = "Itaim",
                ZipCode = "01234-000",
                City = "São Paulo",
                State = "SP",
                Country = "BRA"
            };

            Moip.Models.Person personRequest = new Models.Person
            {
                Name = "Runscope",
                LastName = "Goku",
                TaxDocument = taxDocumentRequest,
                IdentityDocument = identityDocumentRequest,
                BirthDate = "1990-01-01",
                Phone = phoneRequest,
                Address = shippingAddressRequest,
            };

            Moip.Models.AccountRequest accountRequest = new Moip.Models.AccountRequest
            {
                Email = emailRequest,
                Person = personRequest,
                Type = "MERCHANT",
                TransparentAccount = true
            };

            return accountRequest;
        }

        public static Moip.Models.MultiorderRequest CreateMultiorderRequest()
        {
            Moip.Models.TaxDocument taxDocument = new Moip.Models.TaxDocument
            {
                Type = "CPF",
                Number = "22222222222"
            };

            Moip.Models.Phone phone = new Moip.Models.Phone
            {
                CountryCode = "55",
                AreaCode = "11",
                Number = "66778899"
            };

            Moip.Models.ShippingAddress shippingAddress = new Moip.Models.ShippingAddress
            {
                Street = "Rua test",
                StreetNumber = "123",
                Complement = "Ap test",
                District = "Bairro test",
                City = "TestCity",
                State = "SP",
                Country = "BRA",
                ZipCode = "01234000"
            };

            Moip.Models.CustomerRequest customerRequest = new Moip.Models.CustomerRequest
            {
                Fullname = "Fulano de Tal",
                OwnId = "OFulanoDeTal",
                BirthDate = "1990-01-01",
                Email = "fulano@detal.com.br",
                Phone = phone,
                ShippingAddress = shippingAddress,
                TaxDocument = taxDocument
            };


            Moip.Models.SubtotalsRequest subtotalsRequest = new Moip.Models.SubtotalsRequest
            {
                Shipping = 1500,
                Addition = 20,
                Discount = 10
            };

            Moip.Models.AmountOrderRequest amountRequest = new Moip.Models.AmountOrderRequest
            {
                Currency = "BRL",
                Subtotals = subtotalsRequest
            };

            Moip.Models.Item itemsRequest = new Moip.Models.Item
            {
                Product = "Bicicleta Specialized Tarmac 26 Shimano Alivio",
                Quantity = 1,
                Detail = "uma linda bicicleta",
                Price = 2000
            };

            List<Moip.Models.Item> itemsRequestList = new List<Moip.Models.Item>
            {
                itemsRequest
            };

            Moip.Models.MoipAccountReceiverRequest moipAccountReceiver1 = new Moip.Models.MoipAccountReceiverRequest
            {
                Id = "MPA-14AC21F09CAE"
            };

            Moip.Models.AmountReceiverRequest amountReceiver1 = new Moip.Models.AmountReceiverRequest
            {
                Percentual = 50
            };

            Moip.Models.ReceiverRequest receiver1 = new Moip.Models.ReceiverRequest
            {
                MoipAccount = moipAccountReceiver1,
                Type = "PRIMARY",
                Amount = amountReceiver1
            };

            Moip.Models.MoipAccountReceiverRequest moipAccountReceiver2 = new Moip.Models.MoipAccountReceiverRequest
            {
                Id = "MPA-B0D880F21EF1"
            };

            Moip.Models.AmountReceiverRequest amountReceiver2 = new Moip.Models.AmountReceiverRequest
            {
                Percentual = 50
            };

            Moip.Models.ReceiverRequest receiver2 = new Moip.Models.ReceiverRequest
            {
                MoipAccount = moipAccountReceiver2,
                Type = "SECONDARY",
                Amount = amountReceiver2,
                FeePayor = true
            };

            List<Moip.Models.ReceiverRequest> receiverList = new List<Moip.Models.ReceiverRequest>
            {
                receiver1,
                receiver2
            };

            Moip.Models.OrderRequest orderRequest1 = new Moip.Models.OrderRequest
            {
                OwnId = "my_own_id",
                Amount = amountRequest,
                Items = itemsRequestList,
                Customer = customerRequest,
                Receivers = receiverList
            };

            Moip.Models.CustomerRequest customerRequest2 = new Moip.Models.CustomerRequest
            {
                Fullname = "Outro Nome Teste",
                OwnId = "OFulanoDeTal",
                BirthDate = "1990-01-01",
                Email = "fulano@detal.com.br",
                Phone = phone,
                ShippingAddress = shippingAddress,
                TaxDocument = taxDocument
            };

            Moip.Models.OrderRequest orderRequest2 = new Moip.Models.OrderRequest
            {
                OwnId = "my_own_id2",
                Amount = amountRequest,
                Items = itemsRequestList,
                Customer = customerRequest2,
                Receivers = receiverList
            };

            List<Moip.Models.OrderRequest> orderList = new List<Moip.Models.OrderRequest>();

            orderList.Add(orderRequest1);
            orderList.Add(orderRequest2);

            Moip.Models.MultiorderRequest multiOrderRequest = new Moip.Models.MultiorderRequest
            {
                OwnId = "my_own_multi_order_id",
                Orders = orderList
            };
            

            return multiOrderRequest;
        }

        public static Moip.Models.MultipaymentRequest CreateMultipaymetWithCCRequest()
        {
            Moip.Models.TaxDocument taxDocumentRequest = new Moip.Models.TaxDocument
            {
                Type = "CPF",
                Number = "33333333333"
            };

            Moip.Models.Phone phoneRequest = new Moip.Models.Phone
            {
                CountryCode = "55",
                AreaCode = "11",
                Number = "66778899"
            };

            Moip.Models.HolderRequest holderRequest = new Moip.Models.HolderRequest
            {
                Fullname = "Jose Goku da Silva",
                Birthdate = "1988-12-30",
                TaxDocument = taxDocumentRequest,
                Phone = phoneRequest
            };

            Moip.Models.CreditCardRequest creditCardRequest = new Moip.Models.CreditCardRequest
            {
                ExpirationMonth = "02",
                ExpirationYear = "20",
                Number = "5555666677778884",
                Cvc = "123",
                Holder = holderRequest
            };

            Moip.Models.FundingInstrumentRequest fundingInstrumentRequest = new Moip.Models.FundingInstrumentRequest
            {
                Method = "CREDIT_CARD",
                CreditCard = creditCardRequest
            };

            Moip.Models.MultipaymentRequest multipaymentRequest = new Moip.Models.MultipaymentRequest
            {
                InstallmentCount = 1,
                StatementDescriptor = "MyStore",
                FundingInstrument = fundingInstrumentRequest
            };

            return multipaymentRequest;
        }

        public static Moip.Models.MultipaymentBoletoOrDebitRequest CreateMultipaymentWithBoletoRequest()
        {
            Moip.Models.BoletoInstructionLines boletoInstructionLines = new Moip.Models.BoletoInstructionLines()
            {
                First = "TESTETETSTTTST",
                Second = "tfcsddlksjsd",
                Third = "lkshglashiuahgha"
            };

            Moip.Models.BoletoRequest boletoRequest = new Moip.Models.BoletoRequest()
            {
                ExpirationDate = "2020-09-30",
                InstructionLines = boletoInstructionLines,
                LogoUri = "http://"
            };

            Moip.Models.FundingInstrumentRequest fundingInstrumentRequest = new Moip.Models.FundingInstrumentRequest
            {
                Method = "BOLETO",
                Boleto = boletoRequest
            };

            Moip.Models.MultipaymentBoletoOrDebitRequest multipaymentRequest = new Moip.Models.MultipaymentBoletoOrDebitRequest
            {
                FundingInstrument = fundingInstrumentRequest
            };

            return multipaymentRequest;
        }

        public static Moip.Models.MultipaymentBoletoOrDebitRequest CreateMultipaymentWithOnlineDebitRequest()
        {
            Moip.Models.OnlineBankDebitRequest onlineBankDebitRequest = new Moip.Models.OnlineBankDebitRequest()
            {
                BankNumber = 341,
                ExpirationDate = "2020-09-30"
            };

            Moip.Models.FundingInstrumentRequest fundingInstrumentRequest = new Moip.Models.FundingInstrumentRequest
            {
                Method = "ONLINE_BANK_DEBIT",
                OnlineBankDebit = onlineBankDebitRequest
            };

            Moip.Models.MultipaymentBoletoOrDebitRequest multipaymentRequest = new Moip.Models.MultipaymentBoletoOrDebitRequest
            {
                FundingInstrument = fundingInstrumentRequest
            };

            return multipaymentRequest;
        }
    }
}
