using LlvmLibC.Enumerations;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp6AtomicImE4loadENS0_11MemoryOrderENS0_11MemoryScopeE")]
[DemangledName("__llvm_libc_20_1_2_::cpp::Atomic<unsigned long>::load(__llvm_libc_20_1_2_::cpp::MemoryOrder, __llvm_libc_20_1_2_::cpp::MemoryScope)")]
internal static partial class cpp_Atomic_unsigned_long_load_cpp_MemoryOrder_cpp_MemoryScope
{
	public unsafe static long Invoke(fputil_internal_FPStorage_v3nexn* @this, MemoryOrder mem_ord, MemoryScope mem_scope)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = -6148914691236517206L;
		void* ptr = cpp_Atomic_unsigned_long_addressof_unsigned_long.Invoke(&@this->val);
		int num2 = cpp_Atomic_unsigned_long_order_cpp_MemoryOrder.Invoke(mem_ord);
		int num3 = cpp_Atomic_unsigned_long_scope_cpp_MemoryScope.Invoke(mem_scope);
		void* ptr2 = cpp_Atomic_unsigned_long_addressof_unsigned_long.Invoke(&num);
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
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
