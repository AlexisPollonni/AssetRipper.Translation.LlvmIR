using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_inline_memmem_memmem_impl_void_const_unsigned_long_void_const_unsigned_long_0_const
{
	[MangledName("_ZN19__llvm_libc_20_1_2_L13inline_memmemIRKZNS_15__memmem_impl__EPKvmS2_mE3$_0EEPvS2_mS2_mOT_")]
	[DemangledName("void* __llvm_libc_20_1_2_::inline_memmem<__llvm_libc_20_1_2_::__memmem_impl__(void const*, unsigned long, void const*, unsigned long)::$_0 const&>(void const*, unsigned long, void const*, unsigned long, __llvm_libc_20_1_2_::__memmem_impl__(void const*, unsigned long, void const*, unsigned long)::$_0 const&)")]
	[return: NativeType("void*")]
	public unsafe static void* Invoke([MangledName("haystack")][NativeType("void const*")] void* Haystack, [MangledName("haystack_len")][NativeType("unsigned long")] long Haystack_len, [MangledName("needle")][NativeType("void const*")] void* Needle, [MangledName("needle_len")][NativeType("unsigned long")] long Needle_len, [MangledName("comp")][NativeType("__llvm_libc_20_1_2_::__memmem_impl__(void const*, unsigned long, void const*, unsigned long)::$_0 const&")] void* Comp)
	{
		void* result = null;
		void* ptr = null;
		void* ptr2 = null;
		long num = 0L;
		long num2 = 0L;
		unchecked
		{
			if (Needle_len == 0L)
			{
				result = Haystack;
			}
			else if ((ulong)Needle_len > (ulong)Haystack_len)
			{
				result = null;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(8L, &ptr);
				ptr = Haystack;
				Llvm_lifetime_start_p0.Invoke(8L, &ptr2);
				ptr2 = Needle;
				Llvm_lifetime_start_p0.Invoke(8L, &num);
				num = 0L;
				int num3;
				while (true)
				{
					if ((ulong)num > (ulong)(Haystack_len - Needle_len))
					{
						num3 = 2;
						break;
					}
					Llvm_lifetime_start_p0.Invoke(8L, &num2);
					for (num2 = 0L; (ulong)num2 < (ulong)Needle_len && InstructionHelper.BooleanXor(_0_Invoke_5hmekm.Invoke(Comp, ((sbyte*)ptr)[num + num2], ((sbyte*)ptr2)[num2]) != 0, right: true); num2++)
					{
					}
					if (num2 == Needle_len)
					{
						result = (byte*)ptr + num;
						num3 = 1;
					}
					else
					{
						num3 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(8L, &num2);
					switch (num3)
					{
					case 0:
						goto IL_0135;
					}
					break;
					IL_0135:
					num++;
				}
				Llvm_lifetime_end_p0.Invoke(8L, &num);
				if (num3 == 2)
				{
					result = null;
				}
				Llvm_lifetime_end_p0.Invoke(8L, &ptr2);
				Llvm_lifetime_end_p0.Invoke(8L, &ptr);
			}
			return result;
		}
	}
}
