using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_17LOG10_2E")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::LOG10_2")]
internal static partial class Anonymous_namespace_LOG10_2
{
	[FixedAddressValueType]
	private static Fputil_DyadicFloat_kt2kd4 __value;

	public unsafe static Fputil_DyadicFloat_kt2kd4* Pointer => unchecked((Fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref __value));

	public static Fputil_DyadicFloat_kt2kd4 Value
	{
		get
		{
			return __value;
		}
		set
		{
			__value = value;
		}
	}

	unsafe static Anonymous_namespace_LOG10_2()
	{
		Value = new Fputil_DyadicFloat_kt2kd4
		{
			Sign = default(Anon_izyfb7),
			Exponent = -129,
			Mantissa = new BigInt_qdkjbh
			{
				Val = new Cpp_array_i3937k
				{
					Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8103847459014536840L, -7340697496662837352L })
				}
			}
		};
		_ = Pointer;
	}
}
