using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_9rand_nextE")]
[DemangledName("__llvm_libc_20_1_2_::rand_next")]
internal static partial class Rand_next
{
	[FixedAddressValueType]
	private static Fputil_internal_FPStorage_v3nexn __value;

	public unsafe static Fputil_internal_FPStorage_v3nexn* Pointer => unchecked((Fputil_internal_FPStorage_v3nexn*)Unsafe.AsPointer(ref __value));

	public static Fputil_internal_FPStorage_v3nexn Value
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

	unsafe static Rand_next()
	{
		Value = new Fputil_internal_FPStorage_v3nexn
		{
			Val = 1L
		};
		_ = Pointer;
	}
}
