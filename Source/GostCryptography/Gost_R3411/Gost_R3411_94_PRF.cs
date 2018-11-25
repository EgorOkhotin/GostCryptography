﻿using System.Security;

using GostCryptography.Base;
using GostCryptography.Gost_28147_89;

namespace GostCryptography.Gost_R3411
{
	/// <summary>
	/// Реализация PRF на базе алгоритма хэширования ГОСТ Р 34.11-94.
	/// </summary>
	public sealed class Gost_R3411_94_PRF : Gost_R3411_PRF<Gost_R3411_94_HMAC>
	{
		/// <summary>
		/// Наименование алгоритма PRF на базе ГОСТ Р 34.11-94.
		/// </summary>
		public const string AlgorithmNameValue = "urn:ietf:params:xml:ns:cpxmlsec:algorithms:prf-gostr3411";

		/// <summary>
		/// Известные наименования алгоритма PRF на базе ГОСТ Р 34.11-94.
		/// </summary>
		public static readonly string[] KnownAlgorithmNames = { AlgorithmNameValue };


		/// <inheritdoc />
		[SecuritySafeCritical]
		public Gost_R3411_94_PRF(Gost_28147_89_SymmetricAlgorithmBase key, byte[] label, byte[] seed) : base(key, label, seed)
		{
		}

		/// <inheritdoc />
		[SecuritySafeCritical]
		public Gost_R3411_94_PRF(ProviderTypes providerType, byte[] key, byte[] label, byte[] seed) : base(providerType, key, label, seed)
		{
		}


		/// <inheritdoc />
		public override string AlgorithmName => AlgorithmNameValue;


		/// <inheritdoc />
		[SecuritySafeCritical]
		protected override Gost_R3411_94_HMAC CreateHMAC(Gost_28147_89_SymmetricAlgorithm key)
		{
			return new Gost_R3411_94_HMAC(key);
		}
	}
}