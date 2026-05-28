using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Atomic_unsigned_long_load
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp6AtomicImE4loadENS0_11MemoryOrderENS0_11MemoryScopeE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::Atomic<unsigned long>::load(__llvm_libc_20_1_2_::cpp::MemoryOrder, __llvm_libc_20_1_2_::cpp::MemoryScope)")]
	public unsafe static long Invoke([MangledName("this")] Fputil_internal_FPStorage_v3nexn* This, [MangledName("mem_ord")][NativeType("__llvm_libc_20_1_2_::cpp::MemoryOrder")] MemoryOrder Mem_ord, [MangledName("mem_scope")][NativeType("__llvm_libc_20_1_2_::cpp::MemoryScope")] MemoryScope Mem_scope)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = -6148914691236517206L;
		void* ptr = Atomic_unsigned_long_addressof.Invoke(&This->Val);
		int num2 = Atomic_unsigned_long_order.Invoke(Mem_ord);
		int num3 = Atomic_unsigned_long_scope.Invoke(Mem_scope);
		void* ptr2 = Atomic_unsigned_long_addressof.Invoke(&num);
		unchecked
		{
			switch (num2)
			{
			default:
			{
				int num6 = num3;
				if (num6 != 1)
				{
					if (num6 != 2)
					{
						if (num6 != 3)
						{
							if (num6 != 4)
							{
								*(long*)ptr2 = *(long*)ptr;
							}
							else
							{
								*(long*)ptr2 = *(long*)ptr;
							}
						}
						else
						{
							*(long*)ptr2 = *(long*)ptr;
						}
					}
					else
					{
						*(long*)ptr2 = *(long*)ptr;
					}
				}
				else
				{
					*(long*)ptr2 = *(long*)ptr;
				}
				break;
			}
			case 1:
			case 2:
			{
				int num5 = num3;
				if (num5 != 1)
				{
					if (num5 != 2)
					{
						if (num5 != 3)
						{
							if (num5 != 4)
							{
								*(long*)ptr2 = *(long*)ptr;
							}
							else
							{
								*(long*)ptr2 = *(long*)ptr;
							}
						}
						else
						{
							*(long*)ptr2 = *(long*)ptr;
						}
					}
					else
					{
						*(long*)ptr2 = *(long*)ptr;
					}
				}
				else
				{
					*(long*)ptr2 = *(long*)ptr;
				}
				break;
			}
			case 5:
			{
				int num4 = num3;
				if (num4 != 1)
				{
					if (num4 != 2)
					{
						if (num4 != 3)
						{
							if (num4 != 4)
							{
								*(long*)ptr2 = *(long*)ptr;
							}
							else
							{
								*(long*)ptr2 = *(long*)ptr;
							}
						}
						else
						{
							*(long*)ptr2 = *(long*)ptr;
						}
					}
					else
					{
						*(long*)ptr2 = *(long*)ptr;
					}
				}
				else
				{
					*(long*)ptr2 = *(long*)ptr;
				}
				break;
			}
			}
			long result = num;
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
